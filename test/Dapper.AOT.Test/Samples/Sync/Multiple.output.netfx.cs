
#nullable enable
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by:
//     Dapper.CodeAnalysis.CommandGenerator vN/A
// Changes to this file may cause incorrect behavior and
// will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#region Designer generated code
partial class Test
{

	private static global::System.Data.Common.DbCommand? s___dapper__command_Samples_Sync_Multiple_input_cs_List_8;

	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	public partial global::System.Collections.Generic.List<global::SomeType> List(global::System.Data.Common.DbConnection connection, int id, string name)
	{
		// locals
		global::System.Data.Common.DbCommand? __dapper__command = null;
		global::System.Data.Common.DbDataReader? __dapper__reader = null;
		bool __dapper__close = false;
		try
		{
			// prepare connection
			if (connection!.State == global::System.Data.ConnectionState.Closed)
			{
				connection!.Open();
				__dapper__close = true;
			}

			// prepare command (excluding parameter values)
			if ((__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Sync_Multiple_input_cs_List_8, null)) is null)
			{
				__dapper__command = __dapper__CreateCommand(connection!);
			}
			else
			{
				__dapper__command.Connection = connection;
			}

			// assign parameter values
#pragma warning disable CS0618
			__dapper__command.Parameters[0].Value = global::Dapper.Internal.InternalUtilities.AsValue(id);
			__dapper__command.Parameters[1].Value = global::Dapper.Internal.InternalUtilities.AsValue(name);
#pragma warning restore CS0618

			// execute reader
			const global::System.Data.CommandBehavior __dapper__behavior = global::System.Data.CommandBehavior.SequentialAccess | global::System.Data.CommandBehavior.SingleResult | global::System.Data.CommandBehavior.SingleRow;
			__dapper__reader = __dapper__command.ExecuteReader(__dapper__close ? (__dapper__behavior | global::System.Data.CommandBehavior.CloseConnection) : __dapper__behavior);
			__dapper__close = false; // performed via CommandBehavior

			// process single row
			global::System.Collections.Generic.List<global::SomeType> __dapper__result;
			if (__dapper__reader.HasRows && __dapper__reader.Read())
			{
				__dapper__result = global::Dapper.SqlMapper.GetRowParser<global::System.Collections.Generic.List<global::SomeType>>(__dapper__reader).Invoke(__dapper__reader);
			}
			else
			{
				__dapper__result = default!;
			}
			// consume additional results (ensures errors from the server are observed)
			while (__dapper__reader.NextResult()) { }
			return __dapper__result;
		}
		finally
		{
			// cleanup
			__dapper__reader?.Dispose();
			if (__dapper__command is not null)
			{
				__dapper__command.Connection = default;
				__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Sync_Multiple_input_cs_List_8, __dapper__command);
				__dapper__command?.Dispose();
			}
			if (__dapper__close) connection?.Close();
		}

		// command factory for List
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		static global::System.Data.Common.DbCommand __dapper__CreateCommand(global::System.Data.Common.DbConnection connection)
		{
			var command = connection.CreateCommand();
			if (command is global::Oracle.ManagedDataAccess.Client.OracleCommand typed0)
			{
				typed0.BindByName = true;
				typed0.InitialLONGFetchSize = -1;
			}
			command.CommandType = global::System.Data.CommandType.StoredProcedure;
			command.CommandText = @"sproc";
			var args = command.Parameters;

			var p = command.CreateParameter();
			p.ParameterName = @"id";
			p.Direction = global::System.Data.ParameterDirection.Input;
			args.Add(p);

			p = command.CreateParameter();
			p.ParameterName = @"name";
			p.Direction = global::System.Data.ParameterDirection.Input;
			p.Size = -1;
			args.Add(p);

			return command;
		}
	}


	private static global::System.Data.Common.DbCommand? s___dapper__command_Samples_Sync_Multiple_input_cs_Array_11;

	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	public partial global::SomeType[] Array(global::System.Data.Common.DbConnection connection, int id, string name)
	{
		// locals
		global::System.Data.Common.DbCommand? __dapper__command = null;
		global::System.Data.Common.DbDataReader? __dapper__reader = null;
		bool __dapper__close = false;
		try
		{
			// prepare connection
			if (connection!.State == global::System.Data.ConnectionState.Closed)
			{
				connection!.Open();
				__dapper__close = true;
			}

			// prepare command (excluding parameter values)
			if ((__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Sync_Multiple_input_cs_Array_11, null)) is null)
			{
				__dapper__command = __dapper__CreateCommand(connection!);
			}
			else
			{
				__dapper__command.Connection = connection;
			}

			// assign parameter values
#pragma warning disable CS0618
			__dapper__command.Parameters[0].Value = global::Dapper.Internal.InternalUtilities.AsValue(id);
			__dapper__command.Parameters[1].Value = global::Dapper.Internal.InternalUtilities.AsValue(name);
#pragma warning restore CS0618

			// execute reader
			const global::System.Data.CommandBehavior __dapper__behavior = global::System.Data.CommandBehavior.SequentialAccess | global::System.Data.CommandBehavior.SingleResult | global::System.Data.CommandBehavior.SingleRow;
			__dapper__reader = __dapper__command.ExecuteReader(__dapper__close ? (__dapper__behavior | global::System.Data.CommandBehavior.CloseConnection) : __dapper__behavior);
			__dapper__close = false; // performed via CommandBehavior

			// process single row
			global::SomeType[] __dapper__result;
			if (__dapper__reader.HasRows && __dapper__reader.Read())
			{
				__dapper__result = global::Dapper.SqlMapper.GetRowParser<global::SomeType[]>(__dapper__reader).Invoke(__dapper__reader);
			}
			else
			{
				__dapper__result = default!;
			}
			// consume additional results (ensures errors from the server are observed)
			while (__dapper__reader.NextResult()) { }
			return __dapper__result;
		}
		finally
		{
			// cleanup
			__dapper__reader?.Dispose();
			if (__dapper__command is not null)
			{
				__dapper__command.Connection = default;
				__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Sync_Multiple_input_cs_Array_11, __dapper__command);
				__dapper__command?.Dispose();
			}
			if (__dapper__close) connection?.Close();
		}

		// command factory for Array
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		static global::System.Data.Common.DbCommand __dapper__CreateCommand(global::System.Data.Common.DbConnection connection)
		{
			var command = connection.CreateCommand();
			if (command is global::Oracle.ManagedDataAccess.Client.OracleCommand typed0)
			{
				typed0.BindByName = true;
				typed0.InitialLONGFetchSize = -1;
			}
			command.CommandType = global::System.Data.CommandType.StoredProcedure;
			command.CommandText = @"sproc";
			var args = command.Parameters;

			var p = command.CreateParameter();
			p.ParameterName = @"id";
			p.Direction = global::System.Data.ParameterDirection.Input;
			args.Add(p);

			p = command.CreateParameter();
			p.ParameterName = @"name";
			p.Direction = global::System.Data.ParameterDirection.Input;
			p.Size = -1;
			args.Add(p);

			return command;
		}
	}


	private static global::System.Data.Common.DbCommand? s___dapper__command_Samples_Sync_Multiple_input_cs_IList_14;

	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	public partial global::System.Collections.Generic.IList<global::SomeType> IList(global::System.Data.Common.DbConnection connection, int id, string name)
	{
		// locals
		global::System.Data.Common.DbCommand? __dapper__command = null;
		global::System.Data.Common.DbDataReader? __dapper__reader = null;
		bool __dapper__close = false;
		try
		{
			// prepare connection
			if (connection!.State == global::System.Data.ConnectionState.Closed)
			{
				connection!.Open();
				__dapper__close = true;
			}

			// prepare command (excluding parameter values)
			if ((__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Sync_Multiple_input_cs_IList_14, null)) is null)
			{
				__dapper__command = __dapper__CreateCommand(connection!);
			}
			else
			{
				__dapper__command.Connection = connection;
			}

			// assign parameter values
#pragma warning disable CS0618
			__dapper__command.Parameters[0].Value = global::Dapper.Internal.InternalUtilities.AsValue(id);
			__dapper__command.Parameters[1].Value = global::Dapper.Internal.InternalUtilities.AsValue(name);
#pragma warning restore CS0618

			// execute reader
			const global::System.Data.CommandBehavior __dapper__behavior = global::System.Data.CommandBehavior.SequentialAccess | global::System.Data.CommandBehavior.SingleResult | global::System.Data.CommandBehavior.SingleRow;
			__dapper__reader = __dapper__command.ExecuteReader(__dapper__close ? (__dapper__behavior | global::System.Data.CommandBehavior.CloseConnection) : __dapper__behavior);
			__dapper__close = false; // performed via CommandBehavior

			// process single row
			global::System.Collections.Generic.IList<global::SomeType> __dapper__result;
			if (__dapper__reader.HasRows && __dapper__reader.Read())
			{
				__dapper__result = global::Dapper.SqlMapper.GetRowParser<global::System.Collections.Generic.IList<global::SomeType>>(__dapper__reader).Invoke(__dapper__reader);
			}
			else
			{
				__dapper__result = default!;
			}
			// consume additional results (ensures errors from the server are observed)
			while (__dapper__reader.NextResult()) { }
			return __dapper__result;
		}
		finally
		{
			// cleanup
			__dapper__reader?.Dispose();
			if (__dapper__command is not null)
			{
				__dapper__command.Connection = default;
				__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Sync_Multiple_input_cs_IList_14, __dapper__command);
				__dapper__command?.Dispose();
			}
			if (__dapper__close) connection?.Close();
		}

		// command factory for IList
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		static global::System.Data.Common.DbCommand __dapper__CreateCommand(global::System.Data.Common.DbConnection connection)
		{
			var command = connection.CreateCommand();
			if (command is global::Oracle.ManagedDataAccess.Client.OracleCommand typed0)
			{
				typed0.BindByName = true;
				typed0.InitialLONGFetchSize = -1;
			}
			command.CommandType = global::System.Data.CommandType.StoredProcedure;
			command.CommandText = @"sproc";
			var args = command.Parameters;

			var p = command.CreateParameter();
			p.ParameterName = @"id";
			p.Direction = global::System.Data.ParameterDirection.Input;
			args.Add(p);

			p = command.CreateParameter();
			p.ParameterName = @"name";
			p.Direction = global::System.Data.ParameterDirection.Input;
			p.Size = -1;
			args.Add(p);

			return command;
		}
	}


	private static global::System.Data.Common.DbCommand? s___dapper__command_Samples_Sync_Multiple_input_cs_ICollection_17;

	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	public partial global::System.Collections.Generic.ICollection<global::SomeType> ICollection(global::System.Data.Common.DbConnection connection, int id, string name)
	{
		// locals
		global::System.Data.Common.DbCommand? __dapper__command = null;
		global::System.Data.Common.DbDataReader? __dapper__reader = null;
		bool __dapper__close = false;
		try
		{
			// prepare connection
			if (connection!.State == global::System.Data.ConnectionState.Closed)
			{
				connection!.Open();
				__dapper__close = true;
			}

			// prepare command (excluding parameter values)
			if ((__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Sync_Multiple_input_cs_ICollection_17, null)) is null)
			{
				__dapper__command = __dapper__CreateCommand(connection!);
			}
			else
			{
				__dapper__command.Connection = connection;
			}

			// assign parameter values
#pragma warning disable CS0618
			__dapper__command.Parameters[0].Value = global::Dapper.Internal.InternalUtilities.AsValue(id);
			__dapper__command.Parameters[1].Value = global::Dapper.Internal.InternalUtilities.AsValue(name);
#pragma warning restore CS0618

			// execute reader
			const global::System.Data.CommandBehavior __dapper__behavior = global::System.Data.CommandBehavior.SequentialAccess | global::System.Data.CommandBehavior.SingleResult | global::System.Data.CommandBehavior.SingleRow;
			__dapper__reader = __dapper__command.ExecuteReader(__dapper__close ? (__dapper__behavior | global::System.Data.CommandBehavior.CloseConnection) : __dapper__behavior);
			__dapper__close = false; // performed via CommandBehavior

			// process single row
			global::System.Collections.Generic.ICollection<global::SomeType> __dapper__result;
			if (__dapper__reader.HasRows && __dapper__reader.Read())
			{
				__dapper__result = global::Dapper.SqlMapper.GetRowParser<global::System.Collections.Generic.ICollection<global::SomeType>>(__dapper__reader).Invoke(__dapper__reader);
			}
			else
			{
				__dapper__result = default!;
			}
			// consume additional results (ensures errors from the server are observed)
			while (__dapper__reader.NextResult()) { }
			return __dapper__result;
		}
		finally
		{
			// cleanup
			__dapper__reader?.Dispose();
			if (__dapper__command is not null)
			{
				__dapper__command.Connection = default;
				__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Sync_Multiple_input_cs_ICollection_17, __dapper__command);
				__dapper__command?.Dispose();
			}
			if (__dapper__close) connection?.Close();
		}

		// command factory for ICollection
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		static global::System.Data.Common.DbCommand __dapper__CreateCommand(global::System.Data.Common.DbConnection connection)
		{
			var command = connection.CreateCommand();
			if (command is global::Oracle.ManagedDataAccess.Client.OracleCommand typed0)
			{
				typed0.BindByName = true;
				typed0.InitialLONGFetchSize = -1;
			}
			command.CommandType = global::System.Data.CommandType.StoredProcedure;
			command.CommandText = @"sproc";
			var args = command.Parameters;

			var p = command.CreateParameter();
			p.ParameterName = @"id";
			p.Direction = global::System.Data.ParameterDirection.Input;
			args.Add(p);

			p = command.CreateParameter();
			p.ParameterName = @"name";
			p.Direction = global::System.Data.ParameterDirection.Input;
			p.Size = -1;
			args.Add(p);

			return command;
		}
	}


	private static global::System.Data.Common.DbCommand? s___dapper__command_Samples_Sync_Multiple_input_cs_ImmutableArray_20;

	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	public partial global::System.Collections.Immutable.ImmutableArray<global::SomeType> ImmutableArray(global::System.Data.Common.DbConnection connection, int id, string name)
	{
		// locals
		global::System.Data.Common.DbCommand? __dapper__command = null;
		global::System.Data.Common.DbDataReader? __dapper__reader = null;
		bool __dapper__close = false;
		try
		{
			// prepare connection
			if (connection!.State == global::System.Data.ConnectionState.Closed)
			{
				connection!.Open();
				__dapper__close = true;
			}

			// prepare command (excluding parameter values)
			if ((__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Sync_Multiple_input_cs_ImmutableArray_20, null)) is null)
			{
				__dapper__command = __dapper__CreateCommand(connection!);
			}
			else
			{
				__dapper__command.Connection = connection;
			}

			// assign parameter values
#pragma warning disable CS0618
			__dapper__command.Parameters[0].Value = global::Dapper.Internal.InternalUtilities.AsValue(id);
			__dapper__command.Parameters[1].Value = global::Dapper.Internal.InternalUtilities.AsValue(name);
#pragma warning restore CS0618

			// execute reader
			const global::System.Data.CommandBehavior __dapper__behavior = global::System.Data.CommandBehavior.SequentialAccess | global::System.Data.CommandBehavior.SingleResult | global::System.Data.CommandBehavior.SingleRow;
			__dapper__reader = __dapper__command.ExecuteReader(__dapper__close ? (__dapper__behavior | global::System.Data.CommandBehavior.CloseConnection) : __dapper__behavior);
			__dapper__close = false; // performed via CommandBehavior

			// process single row
			global::System.Collections.Immutable.ImmutableArray<global::SomeType> __dapper__result;
			if (__dapper__reader.HasRows && __dapper__reader.Read())
			{
				__dapper__result = global::Dapper.SqlMapper.GetRowParser<global::System.Collections.Immutable.ImmutableArray<global::SomeType>>(__dapper__reader).Invoke(__dapper__reader);
			}
			else
			{
				__dapper__result = default!;
			}
			// consume additional results (ensures errors from the server are observed)
			while (__dapper__reader.NextResult()) { }
			return __dapper__result;
		}
		finally
		{
			// cleanup
			__dapper__reader?.Dispose();
			if (__dapper__command is not null)
			{
				__dapper__command.Connection = default;
				__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Sync_Multiple_input_cs_ImmutableArray_20, __dapper__command);
				__dapper__command?.Dispose();
			}
			if (__dapper__close) connection?.Close();
		}

		// command factory for ImmutableArray
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		static global::System.Data.Common.DbCommand __dapper__CreateCommand(global::System.Data.Common.DbConnection connection)
		{
			var command = connection.CreateCommand();
			if (command is global::Oracle.ManagedDataAccess.Client.OracleCommand typed0)
			{
				typed0.BindByName = true;
				typed0.InitialLONGFetchSize = -1;
			}
			command.CommandType = global::System.Data.CommandType.StoredProcedure;
			command.CommandText = @"sproc";
			var args = command.Parameters;

			var p = command.CreateParameter();
			p.ParameterName = @"id";
			p.Direction = global::System.Data.ParameterDirection.Input;
			args.Add(p);

			p = command.CreateParameter();
			p.ParameterName = @"name";
			p.Direction = global::System.Data.ParameterDirection.Input;
			p.Size = -1;
			args.Add(p);

			return command;
		}
	}


	private static global::System.Data.Common.DbCommand? s___dapper__command_Samples_Sync_Multiple_input_cs_ImmutableList_23;

	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	public partial global::System.Collections.Immutable.ImmutableList<global::SomeType> ImmutableList(global::System.Data.Common.DbConnection connection, int id, string name)
	{
		// locals
		global::System.Data.Common.DbCommand? __dapper__command = null;
		global::System.Data.Common.DbDataReader? __dapper__reader = null;
		bool __dapper__close = false;
		try
		{
			// prepare connection
			if (connection!.State == global::System.Data.ConnectionState.Closed)
			{
				connection!.Open();
				__dapper__close = true;
			}

			// prepare command (excluding parameter values)
			if ((__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Sync_Multiple_input_cs_ImmutableList_23, null)) is null)
			{
				__dapper__command = __dapper__CreateCommand(connection!);
			}
			else
			{
				__dapper__command.Connection = connection;
			}

			// assign parameter values
#pragma warning disable CS0618
			__dapper__command.Parameters[0].Value = global::Dapper.Internal.InternalUtilities.AsValue(id);
			__dapper__command.Parameters[1].Value = global::Dapper.Internal.InternalUtilities.AsValue(name);
#pragma warning restore CS0618

			// execute reader
			const global::System.Data.CommandBehavior __dapper__behavior = global::System.Data.CommandBehavior.SequentialAccess | global::System.Data.CommandBehavior.SingleResult | global::System.Data.CommandBehavior.SingleRow;
			__dapper__reader = __dapper__command.ExecuteReader(__dapper__close ? (__dapper__behavior | global::System.Data.CommandBehavior.CloseConnection) : __dapper__behavior);
			__dapper__close = false; // performed via CommandBehavior

			// process single row
			global::System.Collections.Immutable.ImmutableList<global::SomeType> __dapper__result;
			if (__dapper__reader.HasRows && __dapper__reader.Read())
			{
				__dapper__result = global::Dapper.SqlMapper.GetRowParser<global::System.Collections.Immutable.ImmutableList<global::SomeType>>(__dapper__reader).Invoke(__dapper__reader);
			}
			else
			{
				__dapper__result = default!;
			}
			// consume additional results (ensures errors from the server are observed)
			while (__dapper__reader.NextResult()) { }
			return __dapper__result;
		}
		finally
		{
			// cleanup
			__dapper__reader?.Dispose();
			if (__dapper__command is not null)
			{
				__dapper__command.Connection = default;
				__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Sync_Multiple_input_cs_ImmutableList_23, __dapper__command);
				__dapper__command?.Dispose();
			}
			if (__dapper__close) connection?.Close();
		}

		// command factory for ImmutableList
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		static global::System.Data.Common.DbCommand __dapper__CreateCommand(global::System.Data.Common.DbConnection connection)
		{
			var command = connection.CreateCommand();
			if (command is global::Oracle.ManagedDataAccess.Client.OracleCommand typed0)
			{
				typed0.BindByName = true;
				typed0.InitialLONGFetchSize = -1;
			}
			command.CommandType = global::System.Data.CommandType.StoredProcedure;
			command.CommandText = @"sproc";
			var args = command.Parameters;

			var p = command.CreateParameter();
			p.ParameterName = @"id";
			p.Direction = global::System.Data.ParameterDirection.Input;
			args.Add(p);

			p = command.CreateParameter();
			p.ParameterName = @"name";
			p.Direction = global::System.Data.ParameterDirection.Input;
			p.Size = -1;
			args.Add(p);

			return command;
		}
	}
}
#endregion
