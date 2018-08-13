--LOGIN
CREATE TABLE TB_CARGO
(
  IDCARGO INT NOT NULL,
  DESCRICAO VARCHAR(30) NOT NULL,
  SALARIO NUMBER(11, 2) NOT NULL,
  
  CONSTRAINT PK_IDCARGO PRIMARY KEY (IDCARGO)
);

CREATE TABLE TB_FUNCIONARIO
  (
    IDFUNCIONARIO INT NOT NULL,
    IDCARGO       INT NOT NULL,
    NOME          VARCHAR2(50) NOT NULL,
    SEXO          VARCHAR2(1) NOT NULL,
    DT_NASC       DATE NOT NULL ,
    RG            VARCHAR2(9) NOT NULL,
    CPF           VARCHAR2(11) NOT NULL,
    DATA_CADASTRO DATE NOT NULL ,
    NUM_RESID     VARCHAR2(5) NOT NULL,
    CEP           VARCHAR2(9) NOT NULL,
    TELEFONE      VARCHAR2(11) NOT NULL,
    EMAIL         VARCHAR2(40) UNIQUE,
    COMPLEMENTO   VARCHAR2(40),
    CONSTRAINT PK_IDFUNCIONARIO PRIMARY KEY(IDFUNCIONARIO),
    CONSTRAINT FK_FUNCIONARIO_IDCARGO FOREIGN KEY (IDCARGO) REFERENCES TB_CARGO(IDCARGO)
  );
ALTER TABLE TB_FUNCIONARIO ADD CONSTRAINT VALIDAR_EMAIL_FUNC CHECK (REGEXP_LIKE (EMAIL, '^[A-Za-z]+[A-Za-z0-9.]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}$'));
CREATE TABLE TB_USUARIO
  (
    IDUSUARIO     INT NOT NULL,
    IDFUNCIONARIO INT NOT NULL,
    IDPERMISSAO   INT NOT NULL,
    LOGIN         VARCHAR2(30) NOT NULL,
    SENHA         VARCHAR2(30) NOT NULL,
    STATUS        INT NOT NULL,
    CONSTRAINT PK_IDUSUARIO PRIMARY KEY (IDUSUARIO),
    CONSTRAINT FK_USUARIO_IDFUNCIONARIO FOREIGN KEY (IDFUNCIONARIO) REFERENCES TB_FUNCIONARIO(IDFUNCIONARIO),
    CONSTRAINT UNIQUE_USUARIO UNIQUE(LOGIN),
    CONSTRAINT CHECK_IN_STATUS_USUARIO CHECK(STATUS IN(1, 0))
  );
--SESSAO
CREATE TABLE TB_CAIXA
  (
    IDCAIXA    INT NOT NULL,
    STATUS       INT NOT NULL,
    CONSTRAINT PK_IDESTACAO PRIMARY KEY (IDCAIXA),
    CONSTRAINT CHECK_CAIXA_IN CHECK(STATUS IN (1, 0))
  );
CREATE TABLE TB_EVENTO
  (
    IDEVENTO  INT NOT NULL,
    DESCRICAO VARCHAR2(20) NOT NULL,
    CONSTRAINT PK_IDEVENTO PRIMARY KEY (IDEVENTO)
  );
CREATE TABLE TB_LOG_CAIXA
  (
    IDUSUARIO INT NOT NULL,
    IDEVENTO INT NOT NULL,
    IDCAIXA INT NOT NULL,
    HORA VARCHAR2(30) NOT NULL,
    CONSTRAINT FK_LOG_CAIXA_IDUSUARIO FOREIGN KEY (IDUSUARIO) REFERENCES TB_USUARIO(IDUSUARIO),
    CONSTRAINT FK_LOG_CAIXA_IDEVENTO FOREIGN KEY (IDEVENTO) REFERENCES TB_EVENTO(IDEVENTO),
    CONSTRAINT FK_LOG_CAIXA_IDCAIXA FOREIGN KEY (IDCAIXA) REFERENCES TB_CAIXA(IDCAIXA)
  );
--VENDA
CREATE TABLE TB_VENDA
  (
    CUPOM        INT NOT NULL,
    DATA_EMISSAO DATE NOT NULL,
    STATUS       INT NOT NULL,
    VALOR        NUMBER(9,2) NOT NULL,
    VALOR_PAGO   NUMBER(9,2) NOT NULL,
    IDUSUARIO    INT NOT NULL,
    CONSTRAINT PK_CUPOM PRIMARY KEY (CUPOM),
    CONSTRAINT FK_IDUSUARIO_VENDA FOREIGN KEY (IDUSUARIO) REFERENCES TB_USUARIO(IDUSUARIO),
    CONSTRAINT CHECK_STATUS_IN_VENDA CHECK (STATUS IN(1, 0))
  );
--VENDA PAGAMENTO
CREATE TABLE TB_FORMAPGTO
  (
    IDFORMAPGTO INT NOT NULL,
    DESCRICAO   VARCHAR2(20) NOT NULL,
    CONSTRAINT PK_FORMAPGTO PRIMARY KEY (IDFORMAPGTO)
  );
CREATE TABLE TB_PGTO_VENDA
  (
    CUPOM       INT NOT NULL,
    IDFORMAPGTO INT NOT NULL,
    VALOR       INT NOT NULL,
    CONSTRAINT FK_PGTO_VENDA_CUPOM FOREIGN KEY (CUPOM) REFERENCES TB_VENDA(CUPOM),
    CONSTRAINT FK_PGTO_VENDA_IDFORMAPGTO FOREIGN KEY (IDFORMAPGTO) REFERENCES TB_FORMAPGTO(IDFORMAPGTO)
  );
--PRODUTO E ESTOQUE
CREATE TABLE TB_CATEGORIA
  (
    IDCATEGORIA INT NOT NULL,
    DESCRICAO   VARCHAR2(20) NOT NULL,
    CONSTRAINT PK_IDCATEGORIA PRIMARY KEY (IDCATEGORIA)
  );
CREATE TABLE TB_FORNECEDOR
  (
    IDFORNECEDOR  INT NOT NULL,
    CPF_CNPJ      VARCHAR2(14) NOT NULL,
    COMPLEMENTO   VARCHAR2(30),
    CEP           CHAR(8) NOT NULL,
    DATA_CADASTRO DATE NOT NULL,
    EMAIL         VARCHAR2(30) NOT NULL,
    TELEFONE      CHAR(10) NOT NULL,
    DESCRICAO     VARCHAR(30) NOT NULL,
    CONSTRAINT PK_IDFORNECEDOR PRIMARY KEY (IDFORNECEDOR)
  );
ALTER TABLE TB_FORNECEDOR ADD CONSTRAINT VALIDAR_EMAIL_FORN CHECK (REGEXP_LIKE (EMAIL, '^[A-Za-z]+[A-Za-z0-9.]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}$'));
CREATE TABLE TB_PRODUTO
  (
    IDPRODUTO    INT NOT NULL,
    IDFORNECEDOR INT NOT NULL,
    IDCATEGORIA  INT NOT NULL,
    NOMEPRODUTO  VARCHAR2(100) NOT NULL,
    UNIDADE      VARCHAR(10) NOT NULL,
    VALORVENDA   NUMBER(11, 2) NOT NULL,
    QTATUAL      NUMBER(12) NOT NULL,
    CONSTRAINT PK_IDPRODUTO PRIMARY KEY (IDPRODUTO),
    CONSTRAINT FK_PRODUTO_IDFORNECEDOR FOREIGN KEY (IDFORNECEDOR) REFERENCES TB_FORNECEDOR(IDFORNECEDOR),
    CONSTRAINT FK_PRODUTO_IDCATEGORIA FOREIGN KEY (IDCATEGORIA) REFERENCES TB_CATEGORIA(IDCATEGORIA),
    CONSTRAINT CHECK_QTATUAL CHECK (QTATUAL > -1)
  );
CREATE TABLE TB_PRODUTO_VENDA
  (
    IDPRODUTO INT NOT NULL,
    CUPOM     INT NOT NULL,
    STATUS    INT NOT NULL,
    CONSTRAINT FK_PRODVENDA_IDPRODUTO FOREIGN KEY (IDPRODUTO) REFERENCES TB_PRODUTO(IDPRODUTO),
    CONSTRAINT FK_PRODVENDA_CUPOM FOREIGN KEY (CUPOM) REFERENCES TB_VENDA(CUPOM)
  );
CREATE TABLE TB_MVESTOQUE
(
    IDMOV INT NOT NULL,
    DT_MOV DATE NOT NULL,
    TIPO VARCHAR2(2) NOT NULL,
    QTDEMOV INT NOT NULL,
    CONSTRAINT PK_IDMOV PRIMARY KEY (IDMOV),
    CONSTRAINT CHECK_TIPO_E_S CHECK (TIPO IN ('E', 'S'))
);


CREATE TABLE TB_PRODUTO_MVESTOQUE
  (
    IDPRODUTO INT NOT NULL,
    IDMOV     INT NOT NULL,
    QUANT     INT NOT NULL,
    CONSTRAINT FK_PRODMOV_IDPRODUTO FOREIGN KEY (IDPRODUTO) REFERENCES TB_PRODUTO(IDPRODUTO),
    CONSTRAINT FK_PRODMOV_IDMOV FOREIGN KEY (IDMOV) REFERENCES TB_MVESTOQUE(IDMOV)
  );
  
CREATE SEQUENCE TB_CARGO_SEQ MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER NOCYCLE ;
CREATE SEQUENCE TB_CATEGORIA_SEQ MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER NOCYCLE ;
CREATE SEQUENCE TB_FORNECEDOR_SEQ MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER NOCYCLE ;
CREATE SEQUENCE TB_FUNCIONARIO_SEQ MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER NOCYCLE ;
CREATE SEQUENCE TB_PRODUTO_SEQ MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER NOCYCLE ;
CREATE SEQUENCE TB_MVESTOQUE_SEQ  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE ;
CREATE SEQUENCE TB_VENDA_SEQ  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE ;
CREATE SEQUENCE TB_USUARIO_SEQ  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE ;


--TRIGGERS
create or replace TRIGGER TB_CARGO_TRG 
BEFORE INSERT ON TB_CARGO 
FOR EACH ROW 
BEGIN
  <<COLUMN_SEQUENCES>>
  BEGIN
    IF INSERTING AND :NEW.IDCARGO IS NULL THEN
      SELECT TB_CARGO_SEQ.NEXTVAL INTO :NEW.IDCARGO FROM SYS.DUAL;
    END IF;
  END COLUMN_SEQUENCES;
END;
  
  
  create or replace TRIGGER TB_CATEGORIA_TRG 
BEFORE INSERT ON TB_CATEGORIA 
FOR EACH ROW 
BEGIN
  <<COLUMN_SEQUENCES>>
  BEGIN
    IF INSERTING AND :NEW.IDCATEGORIA IS NULL THEN
      SELECT TB_CATEGORIA_SEQ.NEXTVAL INTO :NEW.IDCATEGORIA FROM SYS.DUAL;
    END IF;
  END COLUMN_SEQUENCES;
END;

create or replace TRIGGER TB_FORNECEDOR_TRG 
BEFORE INSERT ON TB_FORNECEDOR 
FOR EACH ROW 
BEGIN
  <<COLUMN_SEQUENCES>>
  BEGIN
    IF INSERTING AND :NEW.IDFORNECEDOR IS NULL THEN
      SELECT TB_FORNECEDOR_SEQ.NEXTVAL INTO :NEW.IDFORNECEDOR FROM SYS.DUAL;
    END IF;
  END COLUMN_SEQUENCES;
END;

create or replace TRIGGER TB_FUNCIONARIO_TRG 
BEFORE INSERT ON TB_FUNCIONARIO 
FOR EACH ROW 
BEGIN
  <<COLUMN_SEQUENCES>>
  BEGIN
    IF INSERTING AND :NEW.IDFUNCIONARIO IS NULL THEN
      SELECT TB_FUNCIONARIO_SEQ.NEXTVAL INTO :NEW.IDFUNCIONARIO FROM SYS.DUAL;
    END IF;
  END COLUMN_SEQUENCES;
END;

create or replace TRIGGER TB_PRODUTO_TRG 
BEFORE INSERT ON TB_PRODUTO 
FOR EACH ROW 
BEGIN
  <<COLUMN_SEQUENCES>>
  BEGIN
    IF INSERTING AND :NEW.IDPRODUTO IS NULL THEN
      SELECT TB_PRODUTO_SEQ.NEXTVAL INTO :NEW.IDPRODUTO FROM SYS.DUAL;
    END IF;
  END COLUMN_SEQUENCES;
END;

create or replace TRIGGER TB_MVESTOQUE_TRG 
BEFORE INSERT ON TB_MVESTOQUE 
FOR EACH ROW 
BEGIN
  <<COLUMN_SEQUENCES>>
  BEGIN
    IF INSERTING AND :NEW.IDMOV IS NULL THEN
      SELECT TB_MVESTOQUE_SEQ.NEXTVAL INTO :NEW.IDMOV FROM SYS.DUAL;
    END IF;
  END COLUMN_SEQUENCES;
END;

create or replace TRIGGER TB_VENDA_TRG 
BEFORE INSERT ON TB_VENDA 
FOR EACH ROW 
BEGIN
  <<COLUMN_SEQUENCES>>
  BEGIN
    IF INSERTING AND :NEW.CUPOM IS NULL THEN
      SELECT TB_VENDA_SEQ.NEXTVAL INTO :NEW.CUPOM FROM SYS.DUAL;
    END IF;
  END COLUMN_SEQUENCES;
END;

create or replace TRIGGER TB_USUARIO_TRG 
BEFORE INSERT ON TB_USUARIO 
FOR EACH ROW 
BEGIN
  <<COLUMN_SEQUENCES>>
  BEGIN
    IF INSERTING AND :NEW.IDUSUARIO IS NULL THEN
      SELECT TB_USUARIO_SEQ.NEXTVAL INTO :NEW.IDUSUARIO FROM SYS.DUAL;
    END IF;
  END COLUMN_SEQUENCES;
END;

-----------
create or replace TRIGGER TRG_DESCONTO_ESTOQUE 
AFTER INSERT ON TB_PRODUTO_VENDA 
FOR EACH ROW 
BEGIN
  UPDATE TB_PRODUTO SET TB_PRODUTO.QTATUAL = TB_PRODUTO.QTATUAL - 1 WHERE TB_PRODUTO.IDPRODUTO = :NEW.IDPRODUTO;
END;



CREATE OR REPLACE PROCEDURE INSERT_TB_CATEGORIA
  (
    DESCRICAO IN VARCHAR2
  )
AS
BEGIN
  INSERT INTO TB_CATEGORIA
    (IDCATEGORIA, DESCRICAO
    ) VALUES
    (NULL, DESCRICAO
    );
END INSERT_TB_CATEGORIA; 

--



 
CREATE OR REPLACE PROCEDURE INSERT_TB_FORNECEDOR(
    CPF_CNPJ      IN VARCHAR2,
    COMPLEMENTO   IN VARCHAR2,
    CEP           IN VARCHAR2,
    EMAIL         IN VARCHAR2,
    TELEFONE      IN VARCHAR2,
    DESCRICAO     IN VARCHAR2)
AS
BEGIN
  INSERT
  INTO TB_FORNECEDOR
    (
      IDFORNECEDOR,
      CPF_CNPJ,
      COMPLEMENTO,
      CEP,
      DATA_CADASTRO,
      EMAIL,
      TELEFONE,
      DESCRICAO
    )
    VALUES
    (
      NULL,
      CPF_CNPJ,
      COMPLEMENTO,
      CEP,
      SYSDATE,
      EMAIL,
      TELEFONE,
      DESCRICAO
    );
END INSERT_TB_FORNECEDOR;



CREATE OR REPLACE PROCEDURE INSERT_TB_PRODUTO(
    IDFORNECEDOR IN NUMBER,
    IDCATEGORIA  IN NUMBER,
    NOMEPRODUTO  IN VARCHAR2,
    UNIDADE      IN VARCHAR2,
    VALORVENDA   IN NUMBER)
AS
BEGIN
  INSERT
  INTO TB_PRODUTO
    (
      IDPRODUTO,
      IDFORNECEDOR,
      IDCATEGORIA,
      NOMEPRODUTO,
      UNIDADE,
      VALORVENDA,
      QTATUAL
    )
    VALUES
    (
      NULL,
      IDFORNECEDOR,
      IDCATEGORIA,
      NOMEPRODUTO,
      UNIDADE,
      VALORVENDA,
      0
    );
END INSERT_TB_PRODUTO;

create or replace PROCEDURE INSERT_TB_PRODUTO2(
    IDPRODUTO    IN NUMBER,
    IDFORNECEDOR IN NUMBER,
    IDCATEGORIA  IN NUMBER,
    NOMEPRODUTO  IN VARCHAR2,
    UNIDADE      IN VARCHAR2,
    VALORVENDA   IN NUMBER)
AS
BEGIN
  INSERT
  INTO TB_PRODUTO
    (
      IDPRODUTO,
      IDFORNECEDOR,
      IDCATEGORIA,
      NOMEPRODUTO,
      UNIDADE,
      VALORVENDA,
      QTATUAL
    )
    VALUES
    (
      IDPRODUTO,
      IDFORNECEDOR,
      IDCATEGORIA,
      NOMEPRODUTO,
      UNIDADE,
      VALORVENDA,
      0
    );
END INSERT_TB_PRODUTO2;

CREATE OR REPLACE PROCEDURE INSERT_TB_CARGO(
    DESCRICAO IN VARCHAR2,
    SALARIO   IN NUMBER)
AS
BEGIN
  INSERT
  INTO TB_CARGO
    (
      IDCARGO,
      DESCRICAO,
      SALARIO
    )
    VALUES
    (
      NULL,
      DESCRICAO,
      SALARIO
    );
END INSERT_TB_CARGO;

CREATE OR REPLACE PROCEDURE INSERT_TB_FUNCIONARIO(
    IDCARGO       IN NUMBER,
    NOME          IN VARCHAR2,
    SEXO          IN VARCHAR2,
    DT_NASC       IN DATE,
    RG            IN VARCHAR2,
    CPF           IN VARCHAR2,
    NUM_RESID     IN VARCHAR2,
    CEP           IN VARCHAR2,
    TELEFONE      IN VARCHAR2,
    EMAIL         IN VARCHAR2,
    COMPLEMENTO   IN VARCHAR2)
AS
BEGIN
  INSERT
  INTO TB_FUNCIONARIO
    (
      IDFUNCIONARIO,
      IDCARGO,
      NOME,
      SEXO,
      DT_NASC,
      RG,
      CPF,
      DATA_CADASTRO,
      NUM_RESID,
      CEP,
      TELEFONE,
      EMAIL,
      COMPLEMENTO
    )
    VALUES
    (
      NULL,
      IDCARGO,
      NOME,
      SEXO,
      DT_NASC,
      RG,
      CPF,
      SYSDATE,
      NUM_RESID,
      CEP,
      TELEFONE,
      EMAIL,
      COMPLEMENTO
    );
END INSERT_TB_FUNCIONARIO;


CREATE OR REPLACE PROCEDURE INSERT_TB_MVESTOQUE(
    TIPO    IN VARCHAR2,
    QTDEMOV IN NUMBER)
AS
BEGIN
  INSERT
  INTO TB_MVESTOQUE
    (
      IDMOV,
      DT_MOV,
      TIPO,
      QTDEMOV
    )
    VALUES
    (
      NULL,
      SYSDATE,
      TIPO,
      QTDEMOV
    );
END INSERT_TB_MVESTOQUE;
CREATE OR REPLACE PROCEDURE INSERT_TB_PRODUTO_MVESTOQUE(
    IDPRODUTO IN NUMBER,
    IDMOV     IN NUMBER,
    QUANT     IN NUMBER)
AS
BEGIN
  INSERT INTO TB_PRODUTO_MVESTOQUE
    (IDPRODUTO, IDMOV, QUANT
    ) VALUES
    (IDPRODUTO, IDMOV, QUANT
    );
END INSERT_TB_PRODUTO_MVESTOQUE;

CREATE OR REPLACE PROCEDURE INSERT_TB_PRODUTO_VENDA(
    IDPRODUTO IN NUMBER,
    STATUS    IN NUMBER)
AS
BEGIN
  INSERT INTO TB_PRODUTO_VENDA
    (IDPRODUTO, CUPOM, STATUS
    ) VALUES
    (IDPRODUTO, TB_VENDA_SEQ.CURRVAL, STATUS
    );
END INSERT_TB_PRODUTO_VENDA;

CREATE OR REPLACE PROCEDURE INSERT_TB_USUARIO(
    IDFUNCIONARIO IN NUMBER,
    LOGIN         IN VARCHAR2,
    SENHA         IN VARCHAR2,
    STATUS        IN NUMBER,
    IDPERMISSAO   IN NUMBER)
AS
BEGIN
  INSERT
  INTO TB_USUARIO
    (
      IDUSUARIO,
      IDFUNCIONARIO,
      LOGIN,
      SENHA,
      STATUS,
      IDPERMISSAO
    )
    VALUES
    (
      NULL,
      IDFUNCIONARIO,
      LOGIN,
      SENHA,
      STATUS,
      IDPERMISSAO
    );
END INSERT_TB_USUARIO;

CREATE OR REPLACE PROCEDURE INSERT_TB_VENDA(
    STATUS       IN NUMBER,
    VALOR        IN NUMBER,
    VALOR_PAGO   IN NUMBER,
    IDUSUARIO    IN NUMBER)
AS
BEGIN
  INSERT
  INTO TB_VENDA
    (
      CUPOM,
      DATA_EMISSAO,
      STATUS,
      VALOR,
      VALOR_PAGO,
      IDUSUARIO
    )
    VALUES
    (
      NULL,
      SYSDATE,
      STATUS,
      VALOR,
      VALOR_PAGO,
      IDUSUARIO
    );
END INSERT_TB_VENDA;


CREATE OR REPLACE PROCEDURE INSERT_TB_PGTO_VENDA(
    IDFORMAPGTO IN NUMBER,
    VALOR       IN NUMBER
    )
AS
BEGIN
  INSERT INTO TB_PGTO_VENDA
    (CUPOM, IDFORMAPGTO, VALOR
    ) VALUES
    (TB_VENDA_SEQ.CURRVAL, IDFORMAPGTO, VALOR
    );
END INSERT_TB_PGTO_VENDA;

CREATE OR REPLACE PROCEDURE INSERT_TB_LOG_CAIXA(
    IDUSUARIO IN NUMBER,
    IDEVENTO  IN NUMBER,
    IDCAIXA   IN NUMBER)
AS
BEGIN
  INSERT
  INTO TB_LOG_CAIXA
    (
      IDUSUARIO,
      IDEVENTO,
      IDCAIXA,
      HORA
    )
    VALUES
    (
      IDUSUARIO,
      IDEVENTO,
      IDCAIXA,
      TO_CHAR( SYSDATE, 'DD-MM-YY hh24:mi:ss' )
    );
END INSERT_TB_LOG_CAIXA;

CREATE OR REPLACE PROCEDURE UPDATE_QTATUAL(
    IDP IN NUMBER,
    QT     IN NUMBER)
AS
BEGIN
  UPDATE TB_PRODUTO SET QTATUAL = QT WHERE IDPRODUTO = IDP;
END INSERT_TB_PRODUTO_MVESTOQUE;

-- UPDATE
CREATE OR REPLACE PROCEDURE UPDATE_TB_CATEGORIA(
    IDCATEGORI IN NUMBER,
    DESCRICA   IN VARCHAR2)
AS
BEGIN
  UPDATE TB_CATEGORIA
  SET IDCATEGORIA   = IDCATEGORI,
    DESCRICAO       = DESCRICA
  WHERE IDCATEGORIA = IDCATEGORI;
END UPDATE_TB_CATEGORIA;

CREATE OR REPLACE PROCEDURE UPDATE_TB_CARGO(
    IDCARG   IN NUMBER,
    DESCRICA IN VARCHAR2,
    SALARI   IN NUMBER)
AS
BEGIN
  UPDATE TB_CARGO
  SET IDCARGO   = IDCARG,
    DESCRICAO   = DESCRICA,
    SALARIO     = SALARI
  WHERE IDCARGO = IDCARG;
END UPDATE_TB_CARGO;


CREATE OR REPLACE PROCEDURE UPDATE_TB_PRODUTO(
    IDPRODUT    IN NUMBER,
    IDFORNECEDO IN NUMBER,
    IDCATEGORI  IN NUMBER,
    NOMEPRODUT  IN VARCHAR2,
    UNIDAD      IN VARCHAR2,
    VALORVEND   IN NUMBER)
AS
BEGIN
  UPDATE TB_PRODUTO
  SET IDPRODUTO   = IDPRODUT,
    IDFORNECEDOR  = IDFORNECEDO,
    IDCATEGORIA   = IDCATEGORI,
    NOMEPRODUTO   = NOMEPRODUT,
    UNIDADE       = UNIDAD,
    VALORVENDA    = VALORVEND
  WHERE IDPRODUTO = IDPRODUT;
END UPDATE_TB_PRODUTO;


CREATE OR REPLACE PROCEDURE UPDATE_TB_USUARIO(
    IDUSUARI     IN NUMBER,
    IDFUNCIONARI IN NUMBER,
    LOGI         IN VARCHAR2,
    SENH         IN VARCHAR2,
    STATU        IN NUMBER,
    IDPERMISSA   IN NUMBER)
AS
BEGIN
  UPDATE TB_USUARIO
  SET IDUSUARIO   = IDUSUARI,
    IDFUNCIONARIO = IDFUNCIONARI,
    LOGIN         = LOGI,
    SENHA         = SENH,
    STATUS        = STATU,
    IDPERMISSAO   = IDPERMISSA
  WHERE IDUSUARIO = IDUSUARI;
END UPDATE_TB_USUARIO;

CREATE OR REPLACE PROCEDURE UPDATE_TB_FORNECEDOR(
    IDFORNECEDO  IN NUMBER,
    CPF_CNP      IN VARCHAR2,
    COMPLEMENT   IN VARCHAR2,
    CE           IN VARCHAR2,
    EMAI         IN VARCHAR2,
    TELEFON      IN VARCHAR2,
    DESCRICA     IN VARCHAR2)
AS
BEGIN
  UPDATE TB_FORNECEDOR
  SET IDFORNECEDOR   = IDFORNECEDO,
    CPF_CNPJ         = CPF_CNP,
    COMPLEMENTO      = COMPLEMENT,
    CEP              = CE,
    EMAIL            = EMAI,
    TELEFONE         = TELEFON,
    DESCRICAO        = DESCRICA
  WHERE IDFORNECEDOR = IDFORNECEDO;
END UPDATE_TB_FORNECEDOR;

CREATE OR REPLACE PROCEDURE UPDATE_TB_FUNCIONARIO(
    IDFUNCIONARI IN NUMBER,
    IDCARG       IN NUMBER,
    NOM          IN VARCHAR2,
    SEX          IN VARCHAR2,
    DT_NAS       IN DATE,
    R            IN VARCHAR2,
    CP           IN VARCHAR2,
    NUM_RESI     IN VARCHAR2,
    CE           IN VARCHAR2,
    TELEFON      IN VARCHAR2,
    EMAI         IN VARCHAR2,
    COMPLEMENT   IN VARCHAR2)
AS
BEGIN
  UPDATE TB_FUNCIONARIO
  SET IDFUNCIONARIO   = IDFUNCIONARI,
    IDCARGO           = IDCARG,
    NOME              = NOM,
    SEXO              = SEX,
    DT_NASC           = DT_NAS,
    RG                = R,
    CPF               = CP,
    NUM_RESID         = NUM_RESI,
    CEP               = CE,
    TELEFONE          = TELEFON,
    EMAIL             = EMAI,
    COMPLEMENTO       = COMPLEMENT
  WHERE IDFUNCIONARIO = IDFUNCIONARI;
END UPDATE_TB_FUNCIONARIO;


SELECT * FROM TB_MVESTOQUE WHERE IDMOV = (SELECT MAX(IDMOV) FROM TB_MVESTOQUE);

CREATE OR REPLACE VIEW VW_ESTOQUE AS
  SELECT IDPRODUTO AS CODIGO, NOMEPRODUTO, QUANT, DT_MOV
  FROM TB_PRODUTO INNER JOIN TB_PRODUTO_MVESTOQUE USING (IDPRODUTO) INNER JOIN TB_MVESTOQUE USING (IDMOV);

CREATE OR REPLACE VIEW VW_QUANT_VENDIDO AS
SELECT IDPRODUTO, COUNT(*) AS "QUANT", VALORVENDA FROM TB_PRODUTO_VENDA JOIN TB_PRODUTO USING (IDPRODUTO) GROUP BY IDPRODUTO, VALORVENDA;

CREATE OR REPLACE VIEW VW_VENDA AS SELECT CUPOM, DATA_EMISSAO, VALOR, VALOR_PAGO, NOME AS FUNCIONARIO FROM
TB_VENDA INNER JOIN TB_USUARIO USING (IDUSUARIO) INNER JOIN  TB_FUNCIONARIO USING (IDFUNCIONARIO);

CREATE OR REPLACE VIEW VW_PRODUTO_VENDA AS SELECT CUPOM, NOMEPRODUTO, COUNT(IDPRODUTO) AS QUANTIDADE, DATA_EMISSAO FROM TB_PRODUTO JOIN TB_PRODUTO_VENDA USING(IDPRODUTO) JOIN
TB_VENDA USING(CUPOM) GROUP BY CUPOM,IDPRODUTO, NOMEPRODUTO, DATA_EMISSAO;

CREATE OR REPLACE VIEW VW_LOG AS SELECT NOME, DESCRICAO, IDCAIXA AS CAIXA FROM TB_EVENTO JOIN TB_LOG_CAIXA USING(IDEVENTO) JOIN TB_CAIXA USING(IDCAIXA)
JOIN TB_USUARIO USING(IDUSUARIO) JOIN TB_FUNCIONARIO USING(IDFUNCIONARIO);

CREATE OR REPLACE VIEW VW_RELATORIO_VENDA AS
SELECT UPPER(TO_CHAR(TO_DATE(EXTRACT(MONTH FROM DATA_EMISSAO), 'MM'), 'Month')) "MES",  SUM(VALOR) "TOTAL"
FROM TB_VENDA GROUP BY UPPER(TO_CHAR(TO_DATE(EXTRACT(MONTH FROM DATA_EMISSAO), 'MM'), 'Month'))
ORDER BY MES;
---

CREATE OR REPLACE VIEW VW_TOTAL_VENDAS AS
SELECT COUNT(CUPOM) AS "QUANT" FROM TB_VENDA;

CREATE OR REPLACE VIEW VW_TOTAL_VENDAS_JAN AS
SELECT COUNT(CUPOM) AS "QUANT" FROM TB_VENDA WHERE TO_CHAR(DATA_EMISSAO, 'MM') = '01';

CREATE OR REPLACE VIEW VW_TOTAL_VENDAS_FEV AS
SELECT COUNT(CUPOM) AS "QUANT" FROM TB_VENDA WHERE TO_CHAR(DATA_EMISSAO, 'MM') = '02';

CREATE OR REPLACE VIEW VW_TOTAL_VENDAS_MAR AS
SELECT COUNT(CUPOM) AS "QUANT" FROM TB_VENDA WHERE TO_CHAR(DATA_EMISSAO, 'MM') = '03';

CREATE OR REPLACE VIEW VW_TOTAL_VENDAS_ABR AS
SELECT COUNT(CUPOM) AS "QUANT" FROM TB_VENDA WHERE TO_CHAR(DATA_EMISSAO, 'MM') = '04';

CREATE OR REPLACE VIEW VW_TOTAL_VENDAS_MAI AS
SELECT COUNT(CUPOM) AS "QUANT" FROM TB_VENDA WHERE TO_CHAR(DATA_EMISSAO, 'MM') = '05';

CREATE OR REPLACE VIEW VW_TOTAL_VENDAS_JUN AS
SELECT COUNT(CUPOM) AS "QUANT" FROM TB_VENDA WHERE TO_CHAR(DATA_EMISSAO, 'MM') = '06';

CREATE OR REPLACE VIEW VW_TOTAL_VENDAS_JUL AS
SELECT COUNT(CUPOM) AS "QUANT" FROM TB_VENDA WHERE TO_CHAR(DATA_EMISSAO, 'MM') = '07';

CREATE OR REPLACE VIEW VW_TOTAL_VENDAS_AGO AS
SELECT COUNT(CUPOM) AS "QUANT" FROM TB_VENDA WHERE TO_CHAR(DATA_EMISSAO, 'MM') = '08';

CREATE OR REPLACE VIEW VW_TOTAL_VENDAS_SET AS
SELECT COUNT(CUPOM) AS "QUANT" FROM TB_VENDA WHERE TO_CHAR(DATA_EMISSAO, 'MM') = '09';

CREATE OR REPLACE VIEW VW_TOTAL_VENDAS_OUT AS
SELECT COUNT(CUPOM) AS "QUANT" FROM TB_VENDA WHERE TO_CHAR(DATA_EMISSAO, 'MM') = '10';

CREATE OR REPLACE VIEW VW_TOTAL_VENDAS_NOV AS
SELECT COUNT(CUPOM) AS "QUANT" FROM TB_VENDA WHERE TO_CHAR(DATA_EMISSAO, 'MM') = '11';

CREATE OR REPLACE VIEW VW_TOTAL_VENDAS_DEZ AS
SELECT COUNT(CUPOM) AS "QUANT" FROM TB_VENDA WHERE TO_CHAR(DATA_EMISSAO, 'MM') = '12';


CREATE OR REPLACE VIEW VW_VALOR_VENDAS AS
SELECT SUM(VALOR) AS "QUANT" FROM TB_VENDA;

CREATE OR REPLACE VIEW VW_VALOR_VENDAS_JAN AS
SELECT SUM(VALOR) AS "QUANT" FROM TB_VENDA WHERE TO_CHAR(DATA_EMISSAO, 'MM') = '01';

CREATE OR REPLACE VIEW VW_VALOR_VENDAS_FEV AS
SELECT SUM(VALOR) AS "QUANT" FROM TB_VENDA WHERE TO_CHAR(DATA_EMISSAO, 'MM') = '02';

CREATE OR REPLACE VIEW VW_VALOR_VENDAS_MAR AS
SELECT SUM(VALOR) AS "QUANT" FROM TB_VENDA WHERE TO_CHAR(DATA_EMISSAO, 'MM') = '03';

CREATE OR REPLACE VIEW VW_VALOR_VENDAS_ABR AS
SELECT SUM(VALOR) AS "QUANT" FROM TB_VENDA WHERE TO_CHAR(DATA_EMISSAO, 'MM') = '04';

CREATE OR REPLACE VIEW VW_VALOR_VENDAS_MAI AS
SELECT SUM(VALOR) AS "QUANT" FROM TB_VENDA WHERE TO_CHAR(DATA_EMISSAO, 'MM') = '05';

CREATE OR REPLACE VIEW VW_VALOR_VENDAS_JUN AS
SELECT SUM(VALOR) AS "QUANT" FROM TB_VENDA WHERE TO_CHAR(DATA_EMISSAO, 'MM') = '06';

CREATE OR REPLACE VIEW VW_VALOR_VENDAS_JUL AS
SELECT SUM(VALOR) AS "QUANT" FROM TB_VENDA WHERE TO_CHAR(DATA_EMISSAO, 'MM') = '07';

CREATE OR REPLACE VIEW VW_VALOR_VENDAS_AGO AS
SELECT SUM(VALOR) AS "QUANT" FROM TB_VENDA WHERE TO_CHAR(DATA_EMISSAO, 'MM') = '08';

CREATE OR REPLACE VIEW VW_VALOR_VENDAS_SET AS
SELECT SUM(VALOR) AS "QUANT" FROM TB_VENDA WHERE TO_CHAR(DATA_EMISSAO, 'MM') = '09';

CREATE OR REPLACE VIEW VW_VALOR_VENDAS_OUT AS
SELECT SUM(VALOR) AS "QUANT" FROM TB_VENDA WHERE TO_CHAR(DATA_EMISSAO, 'MM') = '10';

CREATE OR REPLACE VIEW VW_VALOR_VENDAS_NOV AS
SELECT SUM(VALOR) AS "QUANT" FROM TB_VENDA WHERE TO_CHAR(DATA_EMISSAO, 'MM') = '11';

CREATE OR REPLACE VIEW VW_VALOR_VENDAS_DEZ AS
SELECT SUM(VALOR) AS "QUANT" FROM TB_VENDA WHERE TO_CHAR(DATA_EMISSAO, 'MM') = '12';

---

CREATE OR REPLACE VIEW VW_TOTAL_VENDIDOS AS
SELECT UPPER(TO_CHAR(TO_DATE(EXTRACT(MONTH FROM TB_VENDA.DATA_EMISSAO), 'MM'), 'Month')) "MES", COUNT(IDPRODUTO) "TOTAL"
FROM TB_PRODUTO_VENDA JOIN TB_VENDA USING(CUPOM)
GROUP BY UPPER(TO_CHAR(TO_DATE(EXTRACT(MONTH FROM TB_VENDA.DATA_EMISSAO), 'MM'), 'Month')) ORDER BY MES;

CREATE OR REPLACE VIEW VW_TOTAL_VENDIDOS_DS AS
SELECT UPPER(TO_CHAR(TO_DATE(EXTRACT(MONTH FROM TB_VENDA.DATA_EMISSAO), 'MM'), 'Month')) "MES", COUNT(IDPRODUTO) "TOTAL", NOMEPRODUTO 
FROM TB_PRODUTO_VENDA JOIN TB_VENDA USING(CUPOM) JOIN TB_PRODUTO USING (IDPRODUTO)
GROUP BY NOMEPRODUTO, UPPER(TO_CHAR(TO_DATE(EXTRACT(MONTH FROM TB_VENDA.DATA_EMISSAO), 'MM'), 'Month')) ORDER BY MES;

CREATE OR REPLACE VIEW VW_VALOR_TOTAL_VENDAS AS
SELECT SUM(VALOR) "TOTAL" FROM TB_VENDA WHERE STATUS = 1;

CREATE OR REPLACE VIEW VW_TOTAL_PRODUTOS_VENDIDOS AS
SELECT COUNT(IDPRODUTO) "TOTAL" FROM TB_PRODUTO_VENDA;

SELECT * FROM VW_ESTOQUE;
SELECT * FROM VW_VENDA;
SELECT * FROM VW_PRODUTO_VENDA;
SELECT * FROM VW_LOG;
SELECT * FROM VW_TOTAL_VENDIDOS_DS;
SELECT * FROM VW_TOTAL_VENDIDOS;
SELECT * FROM VW_VALOR_TOTAL_VENDAS;
SELECT * FROM VW_TOTAL_PRODUTOS_VENDIDOS;
SELECT * FROM VW_RELATORIO_VENDA;
SELECT * FROM VW_TOTAL_VENDAS_S;
SELECT * FROM WWV_FLOW_MONTHS_MONTH;
SELECT IDPRODUTO, QUANT, VALORVENDA * QUANT FROM VW_QUANT_VENDIDO;


INSERT INTO TB_EVENTO (IDEVENTO, DESCRICAO) VALUES ('1', 'LOGIN');
INSERT INTO TB_EVENTO (IDEVENTO, DESCRICAO) VALUES ('2', 'LOGOUT');
INSERT INTO TB_EVENTO (IDEVENTO, DESCRICAO) VALUES ('3', 'VENDA');
INSERT INTO TB_EVENTO (IDEVENTO, DESCRICAO) VALUES ('4', 'ENTRADA ESTOQUE');
INSERT INTO TB_EVENTO (IDEVENTO, DESCRICAO) VALUES ('5', 'CADASTRO');
INSERT INTO TB_EVENTO (IDEVENTO, DESCRICAO) VALUES ('6', 'ALTERA��O');

INSERT INTO TB_CARGO (IDCARGO, DESCRICAO, SALARIO) VALUES (TB_CARGO_SEQ.NEXTVAL, 'ADM', 100);

INSERT INTO TB_FUNCIONARIO (IDFUNCIONARIO,IDCARGO,NOME,SEXO,DT_NASC,RG,CPF,DATA_CADASTRO,NUM_RESID,CEP,TELEFONE,EMAIL,COMPLEMENTO)
values (TB_FUNCIONARIO_SEQ.NEXTVAL, 1,'ADM','F',to_date('21/03/00','DD/MM/RR'),'1231313','12345435345',to_date('26/08/17','DD/MM/RR'),'21321','23131233','1212123213','dsad@dsad.com','12321');
INSERT INTO TB_USUARIO (IDUSUARIO,IDFUNCIONARIO,LOGIN,SENHA,STATUS,IDPERMISSAO) values (TB_USUARIO_SEQ.NEXTVAL,'2','adm','123','1','2');

SELECT * FROM TB_FUNCIONARIO LEFT JOIN TB_USUARIO USING(IDFUNCIONARIO) WHERE IDUSUARIO IS NULL;
