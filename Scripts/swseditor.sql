CREATE TABLE DocumentoSemantico (
  codigo INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  XML Schema_codigo INTEGER UNSIGNED NOT NULL,
  WSDL_codigo INTEGER UNSIGNED NOT NULL,
  documento_wsdl_semantico VARCHAR NULL,
  documento_xml_schema_semantico VARCHAR NULL,
  dtc_inclusao DATETIME NULL,
  dtc_atualizacao DATETIME NULL,
  PRIMARY KEY(codigo),
  INDEX DocumentoSemantico_FKIndex1(WSDL_codigo),
  INDEX DocumentoSemantico_FKIndex2(XML Schema_codigo)
);

CREATE TABLE DocumentoSemantico_Ontologia (
  DocumentoSemantico_codigo INTEGER UNSIGNED NOT NULL,
  Ontologia_codigo INTEGER UNSIGNED NOT NULL,
  PRIMARY KEY(DocumentoSemantico_codigo, Ontologia_codigo),
  INDEX DocumentoSemantico_has_Ontologia_FKIndex1(DocumentoSemantico_codigo),
  INDEX DocumentoSemantico_has_Ontologia_FKIndex2(Ontologia_codigo)
);

CREATE TABLE erro_servicos_anotacao_semantica (
  codigo INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  Servico_codigo INTEGER UNSIGNED NOT NULL,
  desc_erro VARCHAR NULL,
  dtc_inclusao DATE NULL,
  dtc_atualizacao DATE NULL,
  PRIMARY KEY(codigo),
  INDEX erro_servicos_anotacao_semantica_FKIndex1(Servico_codigo)
);

CREATE TABLE Ontologia (
  codigo INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  descricao_ontologia VARCHAR NULL,
  documento_ontologia VARCHAR BINARY NULL,
  dtc_inclusao DATETIME NULL,
  dtc_atualizacao DATETIME NULL,
  PRIMARY KEY(codigo)
);

CREATE TABLE Repositorio_Semnatico (
  DocumentoSemantico_codigo INTEGER UNSIGNED NOT NULL,
  tripla_rdf SET NULL,
  INDEX Repositorio_Semnatico_FKIndex1(DocumentoSemantico_codigo)
);

CREATE TABLE Servico (
  codigo INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  nome VARCHAR NULL,
  descricao VARCHAR NULL,
  dtc_inlcusao DATE NULL,
  dtc_atualizacao DATE NULL,
  PRIMARY KEY(codigo)
);

CREATE TABLE WSDL (
  codigo INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  Servico_codigo INTEGER UNSIGNED NOT NULL,
  descricao VARCHAR NULL,
  documento_wsdl BIT NULL,
  dtc_inclusao DATETIME NULL,
  dtc_atualizacao DATETIME NULL,
  PRIMARY KEY(codigo),
  INDEX WSDL_FKIndex2(Servico_codigo)
);

CREATE TABLE XML_Schema (
  codigo INTEGER UNSIGNED NOT NULL AUTO_INCREMENT,
  WSDL_codigo INTEGER UNSIGNED NOT NULL,
  descricao VARCHAR NULL,
  documento_xml_schema VARCHAR BINARY NULL,
  dtc_inclusao DATETIME NULL,
  dtc_atualizacao DATETIME NULL,
  PRIMARY KEY(codigo),
  INDEX XML Schema_FKIndex1(WSDL_codigo)
);


