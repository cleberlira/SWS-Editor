using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
public class RepositorioOWL
{
	protected SqlCommand vrComando;
	#region "Atributo"
		#endregion
	protected string Lstring_conexao = "";
	#region " Construtor "
	public RepositorioOWL()
	{
		Lstring_conexao = Gcte_conexao_bd;
	}

	public RepositorioOWL(Pstring_conexao)
	{
		
		Lstring_conexao = Pstring_conexao;
	}

	#endregion

	#region "Constantes"

	public const string Gcte_conexao_bd = "StringConexao";
	
	public const string Gcte_conexao_bd_qtd_loop = "QtdMaxLoop";
	#endregion



	#region " GetSQLParameterType "

	private SqlDbType obter_tipos_parametros_sql(object Objeto)
	{
		SqlDbType vrDBType = SqlDbType.NVarChar;

		switch (Objeto.GetType().ToString()) {
			case "System.String":
				vrDBType = SqlDbType.NVarChar;
				break;
			case "System.Byte":
				vrDBType = SqlDbType.TinyInt;
				break;
			case "System.Int16":
				vrDBType = SqlDbType.SmallInt;
				break;
			case "System.Int32":
				vrDBType = SqlDbType.Int;
				break;
			case "System.Int64":
				vrDBType = SqlDbType.BigInt;
				break;
			case "System.Boolean":
				vrDBType = SqlDbType.Bit;
				break;
			case "System.DateTime":
				vrDBType = SqlDbType.DateTime;
				break;
			case "System.Decimal":
				vrDBType = SqlDbType.Decimal;
				break;
			case "System.Double":
				vrDBType = SqlDbType.Float;
				break;
			case "System.Single":
				vrDBType = SqlDbType.Real;
				break;
		}

		return vrDBType;
	}

	#endregion

	#region " Parametro "

	public void limpar_parametro()
	{
		vrComando.Parameters.Clear();
	}

	public void adicionar_parametro(object vrValor, string vrNome)
	{
		SqlParameter vrParametro = obter_parametro(vrNome, obter_tipos_parametros_sql(vrValor), vrValor, ParameterDirection.Input, -1);
		vrComando.Parameters.Add(vrParametro);
	}

	public void adicionar_parametro(object vrValor, SqlDbType vrTipo, string vrNome)
	{
		SqlParameter vrParametro = obter_parametro(vrNome, vrTipo, vrValor, ParameterDirection.Input, -1);
		vrComando.Parameters.Add(vrParametro);
	}

	private SqlParameter obter_parametro(string vrNome, SqlDbType vrDataType, object vrValor, ParameterDirection vrDirecao, Int32 vrTamanho)
	{
		SqlParameter vrParam = new SqlParameter(vrNome, vrDataType);

		vrParam.Value = vrValor;
		vrParam.Direction = vrDirecao;

		if ((vrTamanho != -1)) {
			vrParam.Size = vrTamanho;
		}

		return vrParam;
	}


	#endregion

	#region " ExecutarSql "
	public Int32 executar_sql(string vrClausula)
	{
		//, Optional ByVal PboRecepcao As Boolean = False) As Int32
		SqlConnection Conexao = null;
		Int32 Lretorno = default(Int32);
		try {
			//Conexao = criar_conexao(PboRecepcao)
			Conexao = criar_conexao();
			preparar_comando(vrClausula, CommandType.Text, Conexao);
			Lretorno = vrComando.ExecuteNonQuery();
		} catch (Exception ex) {
			throw ex;
		} finally {
			if ((Conexao != null)) {
				Conexao.Close();
			}
			vrComando.Dispose();
		}
		return Lretorno;
	}

	public Int32 executar_sql(string strProcedure, ArrayList Pparameters)
	{
		
		SqlConnection Conexao = null;
		Int32 Lretorno = default(Int32);
		try {
			
			Conexao = criar_conexao();
			preparar_comando(strProcedure, CommandType.StoredProcedure, Pparameters, Conexao);
			Lretorno = vrComando.ExecuteNonQuery();
		} catch (Exception ex) {
			throw ex;
		} finally {
			if ((Conexao != null)) {
				Conexao.Close();
			}
			vrComando.Dispose();
		}
		return Lretorno;
	}

	#endregion

	#region " ExecutarDataSet "
	public DataSet obter_registro_dst(string strProcedure)
	{
		

		DataSet DSRetorno = new DataSet();
		SqlDataAdapter Adapter = null;
		SqlConnection Conexao = null;

		try {
			
			Conexao = criar_conexao();
			preparar_comando(strProcedure, CommandType.StoredProcedure, Conexao);
			Adapter = new SqlDataAdapter(vrComando);
			Adapter.Fill(DSRetorno);
		} catch (Exception ex) {
			throw ex;
		} finally {
			if ((Conexao != null)) {
				Conexao.Close();
			}
			vrComando.Dispose();
		}

		return DSRetorno;
	}

	public DataSet obter_registro_dst(string strProcedure, ArrayList Pparameters)
	{
		

		DataSet DSRetorno = new DataSet();
		SqlDataAdapter Adapter = null;
		SqlConnection Conexao = null;
		try {
			
			Conexao = criar_conexao();
			preparar_comando(strProcedure, CommandType.StoredProcedure, Pparameters, Conexao);
			Adapter = new SqlDataAdapter(vrComando);
			Adapter.Fill(DSRetorno);
		} catch (Exception ex) {
			throw ex;
		} finally {
			if ((Conexao != null)) {
				Conexao.Close();
			}
			vrComando.Dispose();
		}
		return DSRetorno;
	}

	public bool obter_registro_bool(string vrClausula)
	{
		

		bool Retorno = false;
		SqlDataReader Adapter = null;
		SqlConnection Conexao = null;

		try {
			Conexao = criar_conexao();
			preparar_comando(vrClausula, CommandType.StoredProcedure, Conexao);
			Adapter = vrComando.ExecuteReader();
			if ((Adapter != null)) {
				Adapter.Read();
				Retorno = Adapter.HasRows;
				Adapter.Close();
			}
		} catch (Exception ex) {
			throw ex;
		} finally {
			if ((Conexao != null)) {
				Conexao.Close();
			}
			vrComando.Dispose();
		}
		return Retorno;
	}

	public bool obter_registro_bool(string vrClausula, ArrayList Pparameters)
	{
		

		bool Retorno = false;
		SqlDataReader Adapter = null;
		SqlConnection Conexao = null;

		try {
			Conexao = criar_conexao();
			preparar_comando(vrClausula, CommandType.StoredProcedure, Pparameters, Conexao);
			Adapter = vrComando.ExecuteReader();
			if ((Adapter != null)) {
				Adapter.Read();
				Retorno = Adapter.HasRows;
				Adapter.Close();
			}
		} catch (Exception ex) {
			throw ex;
		} finally {
			if ((Conexao != null)) {
				Conexao.Close();
			}
			vrComando.Dispose();
		}
		return Retorno;
	}

	public bool obter_registro_bool(string strPrcedure, CommandType PcmdType)
	{
		

		bool Retorno = false;
		SqlDataReader Adapter = null;
		SqlConnection Conexao = null;

		try {
			Conexao = criar_conexao();
			preparar_comando(strPrcedure, PcmdType, Conexao);
			Adapter = vrComando.ExecuteReader();
			if ((Adapter != null)) {
				Adapter.Read();
				Retorno = Adapter.HasRows;
				Adapter.Close();
			}
		} catch (Exception ex) {
			throw ex;
		} finally {
			if ((Conexao != null)) {
				Conexao.Close();
			}
			vrComando.Dispose();
		}
		return Retorno;
	}

	public int obter_registro_sp(string vrClausula, CommandType PcmdType, ArrayList Pparameters)
	{
	
		int Retorno = 0;
		SqlConnection Conexao = null;
		try {
			Conexao = criar_conexao();
			
			preparar_comando(vrClausula, PcmdType, Pparameters, Conexao);
			Retorno = vrComando.ExecuteScalar();
		} catch (Exception ex) {
			throw ex;
		} finally {
			if ((Conexao != null)) {
				Conexao.Close();
			}
			vrComando.Dispose();
		}
		return Retorno;
	}

	public DataSet obter_registro_sp_dst(string vrClausula, CommandType PcmdType, ArrayList Pparameters)
	{
	

		DataSet DSRetorno = new DataSet();
		SqlDataAdapter Adapter = null;
		SqlConnection Conexao = null;
		try {
			Conexao = criar_conexao();
			
			preparar_comando(vrClausula, PcmdType, Pparameters, Conexao);
			Adapter = new SqlDataAdapter(vrComando);
			Adapter.Fill(DSRetorno);
		} catch (Exception ex) {
			throw ex;
		} finally {
			if ((Conexao != null)) {
				Conexao.Close();
			}
			vrComando.Dispose();
		}
		return DSRetorno;
	}
	#endregion

	#region " PrepararComando "


	protected void preparar_comando(string clausulaSQL, CommandType cmdType, SqlConnection conexaoCorrente)
	{
		SqlTransaction objTransacao = null;
		vrComando = new SqlCommand();

		objTransacao = obter_transacao();

		if ((objTransacao != null)) {
			conexaoCorrente = objTransacao.Connection;
			vrComando.Transaction = objTransacao;
		}

		if ((conexaoCorrente == null)) {
			conexaoCorrente = criar_conexao();
		}

		vrComando.Connection = conexaoCorrente;
		vrComando.CommandText = clausulaSQL;
		vrComando.CommandType = cmdType;
		vrComando.CommandTimeout = conexaoCorrente.ConnectionTimeout;

	}


	protected void preparar_comando(string clausulaSQL, CommandType cmdType, ArrayList parameters, SqlConnection conexaoCorrente)
	{
		SqlTransaction objTransacao = null;
		vrComando = new SqlCommand();

		objTransacao = obter_transacao();

		if ((objTransacao != null)) {
			conexaoCorrente = objTransacao.Connection;
			vrComando.Transaction = objTransacao;
		}

		if ((conexaoCorrente == null)) {
			conexaoCorrente = criar_conexao();
		}

		vrComando.Connection = conexaoCorrente;
		vrComando.CommandText = clausulaSQL;
		vrComando.CommandTimeout = conexaoCorrente.ConnectionTimeout;

		SqlParameter param = null;
		foreach (SqlParameter param_loopVariable in parameters) {
			param = param_loopVariable;
			vrComando.Parameters.Add(param);
		}
		vrComando.CommandType = cmdType;

	}

	#endregion

	#region " Transação "

	protected SqlTransaction obter_transacao()
	{
		SqlTransaction transacao = (SqlTransaction)CallContext.GetData("transacao" + Lstring_conexao);
		return transacao;
	}

	
	public static void comecar_transacao(string Ptipo_conexao)
	{
		IDbTransaction objTransacao = (IDbTransaction)CallContext.GetData("transacao" + Ptipo_conexao);
		Int32 contador = default(Int32);

		if ((objTransacao == null)) {
			SqlConnection conexao = criar_conexao(Ptipo_conexao);
			//, PboRecepcao)
			objTransacao = conexao.BeginTransaction(IsolationLevel.ReadCommitted);
			CallContext.SetData("transacao" + Ptipo_conexao, objTransacao);
			CallContext.SetData("contadorTransacao" + Ptipo_conexao, 1);
			CallContext.SetData("commitTransacao" + Ptipo_conexao, true);
		} else {
			if ((CallContext.GetData("contadorTransacao" + Ptipo_conexao) != null)) {
				contador = Convert.ToInt32(CallContext.GetData("contadorTransacao" + Ptipo_conexao));
				contador = contador + 1;
				CallContext.SetData("contadorTransacao" + Ptipo_conexao, contador);
			}
		}
	}

	public static void confirmar_transacao(string Ptipo_conexao)
	{
		IDbConnection conexaoCorrente = null;
		IDbTransaction transacaoCorrente = (IDbTransaction)CallContext.GetData("transacao" + Ptipo_conexao);
		bool fecharConexao = false;
		Int32 contador = default(Int32);
		bool commit = false;

		if ((transacaoCorrente != null)) {
			try {
				if (((CallContext.GetData("contadorTransacao" + Ptipo_conexao) != null) & (CallContext.GetData("commitTransacao" + Ptipo_conexao) != null))) {
					contador = Convert.ToInt32(CallContext.GetData("contadorTransacao" + Ptipo_conexao));
					commit = Convert.ToBoolean(CallContext.GetData("commitTransacao" + Ptipo_conexao));

					if ((contador == 1)) {
						fecharConexao = true;
						conexaoCorrente = transacaoCorrente.Connection;
						try {
							if ((commit)) {
								transacaoCorrente.Commit();
							} else {
								transacaoCorrente.Rollback();
							}
						} finally {
							CallContext.FreeNamedDataSlot("transacao" + Ptipo_conexao);
							CallContext.FreeNamedDataSlot("contadorTransacao" + Ptipo_conexao);
							CallContext.FreeNamedDataSlot("commitTransacao" + Ptipo_conexao);
						}
					} else {
						contador = contador - 1;
						CallContext.SetData("contadorTransacao" + Ptipo_conexao, contador);
					}
				} else {
					throw new Exception("Contexto de transação contém informações incompletas");
				}
			} finally {
				if ((fecharConexao)) {
					if ((conexaoCorrente != null)) {
						if ((conexaoCorrente.State != ConnectionState.Closed)) {
							conexaoCorrente.Close();
						}
					}
				}
			}
		}
	}

	public static void desfazer_transacao(string Ptipo_conexao)
	{
		IDbConnection conexaoCorrente = null;
		bool fecharConexao = false;
		IDbTransaction transacaoCorrente = (IDbTransaction)CallContext.GetData("transacao" + Ptipo_conexao);
		Int32 contador = default(Int32);

		if ((transacaoCorrente != null)) {
			try {
				if (((CallContext.GetData("contadorTransacao" + Ptipo_conexao) != null) & (CallContext.GetData("commitTransacao" + Ptipo_conexao) != null))) {
					contador = Convert.ToInt32(CallContext.GetData("contadorTransacao" + Ptipo_conexao));
					CallContext.SetData("commitTransacao" + Ptipo_conexao, false);

					if ((contador == 1)) {
						fecharConexao = true;
						conexaoCorrente = transacaoCorrente.Connection;
						try {
							transacaoCorrente.Rollback();
						} finally {
							CallContext.FreeNamedDataSlot("transacao" + Ptipo_conexao);
							CallContext.FreeNamedDataSlot("contadorTransacao" + Ptipo_conexao);
							CallContext.FreeNamedDataSlot("commitTransacao" + Ptipo_conexao);
						}
					} else {
						contador = contador - 1;
						CallContext.SetData("contadorTransacao" + Ptipo_conexao, contador);
					}
				} else {
					throw new Exception("Contexto de transação contém informações incompletas");
				}
			} finally {
				if ((fecharConexao)) {
					if ((conexaoCorrente != null)) {
						if ((conexaoCorrente.State != ConnectionState.Closed)) {
							conexaoCorrente.Close();
						}
					}
				}
			}
		}

	}

	#endregion

	#region "Criar Parâmetro"
	/// <summary>
	/// Criar o parâmetro para instrução SQL.
	/// </summary>
	/// <param name="Pnome"></param>
	/// <param name="Ptipo"></param>
	/// <param name="Pvalor"></param>
	/// <returns></returns>
	/// <remarks></remarks>
	/// <descricaoAlteracao>Criação para a versão 03.00.00</descricaoAlteracao>
	public SqlParameter criar_parametro(string Pnome, SqlDbType Ptipo, object Pvalor, bool PboStringVazia = false)
	{
		SqlParameter param = new SqlParameter();
		param.ParameterName = Pnome;
		param.SqlDbType = Ptipo;
		if (Pvalor == null) {
			param.Value = DBNull.Value;
		} else {
			if ((Ptipo == SqlDbType.VarChar & Pvalor.ToString().Length == 0) & !PboStringVazia) {
				param.Value = DBNull.Value;
			} else {
				param.Value = Pvalor;
			}
		}
		return param;
	}
	#endregion

	#region " Conexão "

	protected virtual SqlConnection criar_conexao()
	{

		SqlConnection Fcnn = null;

		

		try {
			System.Configuration.AppSettingsReader app_reader = new System.Configuration.AppSettingsReader();
			string str_conexao = Convert.ToString(app_reader.GetValue(Lstring_conexao, typeof(string)));

			Fcnn = new SqlConnection(str_conexao);
			Fcnn.Open();

			return Fcnn;

		} catch (SqlException ex) {
			throw ex;
		}

	}

	protected static SqlConnection criar_conexao(string Ptipo_conexao)
	{
		SqlConnection Fcnn = null;

		
		try {
			System.Configuration.AppSettingsReader app_reader = new System.Configuration.AppSettingsReader();
			string str_conexao = Convert.ToString(app_reader.GetValue(Ptipo_conexao, typeof(string)));

			Fcnn = new SqlConnection(str_conexao);
			Fcnn.Open();
			return Fcnn;
		} catch (SqlException ex) {
			throw ex;
		}

		
	}
	#endregion

}