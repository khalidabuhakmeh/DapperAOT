// Output code has 10 diagnostics from 'Dapper.AOT\Dapper.CodeAnalysis.CommandGenerator\Multiple.output.netfx.cs':
// Dapper.AOT\Dapper.CodeAnalysis.CommandGenerator\Multiple.output.netfx.cs(71,11): error CS0029: Cannot implicitly convert type 'System.Collections.Generic.List<SomeType>' to 'System.Threading.Tasks.Task<System.Collections.Generic.List<SomeType>>'
// Dapper.AOT\Dapper.CodeAnalysis.CommandGenerator\Multiple.output.netfx.cs(173,11): error CS0029: Cannot implicitly convert type 'System.Collections.Generic.List<SomeType>' to 'System.Threading.Tasks.ValueTask<System.Collections.Generic.List<SomeType>>'
// Dapper.AOT\Dapper.CodeAnalysis.CommandGenerator\Multiple.output.netfx.cs(275,11): error CS0029: Cannot implicitly convert type 'System.Collections.Generic.List<SomeType>' to 'System.Threading.Tasks.Task<System.Collections.Generic.List<SomeType>>'
// Dapper.AOT\Dapper.CodeAnalysis.CommandGenerator\Multiple.output.netfx.cs(377,11): error CS0029: Cannot implicitly convert type 'System.Collections.Generic.List<SomeType>' to 'System.Threading.Tasks.ValueTask<System.Collections.Generic.List<SomeType>>'
// Dapper.AOT\Dapper.CodeAnalysis.CommandGenerator\Multiple.output.netfx.cs(579,11): error CS0029: Cannot implicitly convert type 'System.Collections.Generic.List<SomeType>' to 'System.Threading.Tasks.ValueTask<System.Collections.Generic.IList<SomeType>>'
// Dapper.AOT\Dapper.CodeAnalysis.CommandGenerator\Multiple.output.netfx.cs(681,11): error CS0029: Cannot implicitly convert type 'System.Collections.Generic.List<SomeType>' to 'System.Threading.Tasks.ValueTask<System.Collections.Generic.ICollection<SomeType>>'
// Dapper.AOT\Dapper.CodeAnalysis.CommandGenerator\Multiple.output.netfx.cs(784,11): error CS0029: Cannot implicitly convert type 'System.Collections.Immutable.ImmutableArray<SomeType>' to 'System.Threading.Tasks.ValueTask<System.Collections.Immutable.ImmutableArray<SomeType>>'
// Dapper.AOT\Dapper.CodeAnalysis.CommandGenerator\Multiple.output.netfx.cs(890,19): error CS0029: Cannot implicitly convert type 'System.Collections.Immutable.ImmutableList<SomeType>' to 'System.Threading.Tasks.ValueTask<System.Collections.Immutable.ImmutableList<SomeType>>'
// Dapper.AOT\Dapper.CodeAnalysis.CommandGenerator\Multiple.output.netfx.cs(891,19): error CS0029: Cannot implicitly convert type 'System.Collections.Immutable.ImmutableList<SomeType>' to 'System.Threading.Tasks.ValueTask<System.Collections.Immutable.ImmutableList<SomeType>>'
// Dapper.AOT\Dapper.CodeAnalysis.CommandGenerator\Multiple.output.netfx.cs(892,20): error CS0029: Cannot implicitly convert type 'System.Collections.Immutable.ImmutableList<SomeType>' to 'System.Threading.Tasks.ValueTask<System.Collections.Immutable.ImmutableList<SomeType>>'

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

	// available inactive command for TaskAsync (interlocked)
	private static global::System.Data.Common.DbCommand? s___dapper__command_Samples_Async_Multiple_input_cs_TaskAsync_10;

	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	public partial global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<global::SomeType>> TaskAsync(global::System.Data.Common.DbConnection connection, int id, string name)
	{
		// locals
		global::System.Data.Common.DbCommand? __dapper__command = null;
		global::System.Data.Common.DbDataReader? __dapper__reader = null;
		bool __dapper__close = false;
		global::System.Collections.Generic.List<global::SomeType> __dapper__result;
		try
		{
			// prepare connection
			if (connection!.State == global::System.Data.ConnectionState.Closed)
			{
				connection!.Open();
				__dapper__close = true;
			}

			// prepare command (excluding parameter values)
			if ((__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Async_Multiple_input_cs_TaskAsync_10, null)) is null)
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

			// process multiple rows
			__dapper__result = new global::System.Collections.Generic.List<global::SomeType>();
			if (__dapper__reader.HasRows)
			{
				var __dapper__parser = global::Dapper.SqlMapper.GetRowParser<global::SomeType>(__dapper__reader);
				while (__dapper__reader.Read())
				{
					__dapper__result.Add(__dapper__parser(__dapper__reader));
				}
			}
			// consume additional results (ensures errors from the server are observed)
			while (__dapper__reader.NextResult()) { }

			// TODO: post-process parameters

			// return rowset
			return __dapper__result;
		}
		finally
		{
			// cleanup
			__dapper__reader?.Dispose();
			if (__dapper__command is not null)
			{
				__dapper__command.Connection = default;
				__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Async_Multiple_input_cs_TaskAsync_10, __dapper__command);
				__dapper__command?.Dispose();
			}
			if (__dapper__close) connection?.Close();
		}

		// command factory for TaskAsync
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


	// available inactive command for ValueTaskAsync (interlocked)
	private static global::System.Data.Common.DbCommand? s___dapper__command_Samples_Async_Multiple_input_cs_ValueTaskAsync_13;

	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	public partial global::System.Threading.Tasks.ValueTask<global::System.Collections.Generic.List<global::SomeType>> ValueTaskAsync(global::System.Data.Common.DbConnection connection, int id, string name)
	{
		// locals
		global::System.Data.Common.DbCommand? __dapper__command = null;
		global::System.Data.Common.DbDataReader? __dapper__reader = null;
		bool __dapper__close = false;
		global::System.Collections.Generic.List<global::SomeType> __dapper__result;
		try
		{
			// prepare connection
			if (connection!.State == global::System.Data.ConnectionState.Closed)
			{
				connection!.Open();
				__dapper__close = true;
			}

			// prepare command (excluding parameter values)
			if ((__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Async_Multiple_input_cs_ValueTaskAsync_13, null)) is null)
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

			// process multiple rows
			__dapper__result = new global::System.Collections.Generic.List<global::SomeType>();
			if (__dapper__reader.HasRows)
			{
				var __dapper__parser = global::Dapper.SqlMapper.GetRowParser<global::SomeType>(__dapper__reader);
				while (__dapper__reader.Read())
				{
					__dapper__result.Add(__dapper__parser(__dapper__reader));
				}
			}
			// consume additional results (ensures errors from the server are observed)
			while (__dapper__reader.NextResult()) { }

			// TODO: post-process parameters

			// return rowset
			return __dapper__result;
		}
		finally
		{
			// cleanup
			__dapper__reader?.Dispose();
			if (__dapper__command is not null)
			{
				__dapper__command.Connection = default;
				__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Async_Multiple_input_cs_ValueTaskAsync_13, __dapper__command);
				__dapper__command?.Dispose();
			}
			if (__dapper__close) connection?.Close();
		}

		// command factory for ValueTaskAsync
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


	// available inactive command for TaskWithCancellationAsync (interlocked)
	private static global::System.Data.Common.DbCommand? s___dapper__command_Samples_Async_Multiple_input_cs_TaskWithCancellationAsync_16;

	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	public partial global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<global::SomeType>> TaskWithCancellationAsync(global::System.Data.Common.DbConnection connection, int id, string name, global::System.Threading.CancellationToken cancellation)
	{
		// locals
		global::System.Data.Common.DbCommand? __dapper__command = null;
		global::System.Data.Common.DbDataReader? __dapper__reader = null;
		bool __dapper__close = false;
		global::System.Collections.Generic.List<global::SomeType> __dapper__result;
		try
		{
			// prepare connection
			if (connection!.State == global::System.Data.ConnectionState.Closed)
			{
				connection!.Open();
				__dapper__close = true;
			}

			// prepare command (excluding parameter values)
			if ((__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Async_Multiple_input_cs_TaskWithCancellationAsync_16, null)) is null)
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

			// process multiple rows
			__dapper__result = new global::System.Collections.Generic.List<global::SomeType>();
			if (__dapper__reader.HasRows)
			{
				var __dapper__parser = global::Dapper.SqlMapper.GetRowParser<global::SomeType>(__dapper__reader);
				while (__dapper__reader.Read())
				{
					__dapper__result.Add(__dapper__parser(__dapper__reader));
				}
			}
			// consume additional results (ensures errors from the server are observed)
			while (__dapper__reader.NextResult()) { }

			// TODO: post-process parameters

			// return rowset
			return __dapper__result;
		}
		finally
		{
			// cleanup
			__dapper__reader?.Dispose();
			if (__dapper__command is not null)
			{
				__dapper__command.Connection = default;
				__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Async_Multiple_input_cs_TaskWithCancellationAsync_16, __dapper__command);
				__dapper__command?.Dispose();
			}
			if (__dapper__close) connection?.Close();
		}

		// command factory for TaskWithCancellationAsync
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


	// available inactive command for ValueWithCancellationTaskAsync (interlocked)
	private static global::System.Data.Common.DbCommand? s___dapper__command_Samples_Async_Multiple_input_cs_ValueWithCancellationTaskAsync_19;

	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	public partial global::System.Threading.Tasks.ValueTask<global::System.Collections.Generic.List<global::SomeType>> ValueWithCancellationTaskAsync(global::System.Data.Common.DbConnection connection, int id, string name, global::System.Threading.CancellationToken cancellation)
	{
		// locals
		global::System.Data.Common.DbCommand? __dapper__command = null;
		global::System.Data.Common.DbDataReader? __dapper__reader = null;
		bool __dapper__close = false;
		global::System.Collections.Generic.List<global::SomeType> __dapper__result;
		try
		{
			// prepare connection
			if (connection!.State == global::System.Data.ConnectionState.Closed)
			{
				connection!.Open();
				__dapper__close = true;
			}

			// prepare command (excluding parameter values)
			if ((__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Async_Multiple_input_cs_ValueWithCancellationTaskAsync_19, null)) is null)
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

			// process multiple rows
			__dapper__result = new global::System.Collections.Generic.List<global::SomeType>();
			if (__dapper__reader.HasRows)
			{
				var __dapper__parser = global::Dapper.SqlMapper.GetRowParser<global::SomeType>(__dapper__reader);
				while (__dapper__reader.Read())
				{
					__dapper__result.Add(__dapper__parser(__dapper__reader));
				}
			}
			// consume additional results (ensures errors from the server are observed)
			while (__dapper__reader.NextResult()) { }

			// TODO: post-process parameters

			// return rowset
			return __dapper__result;
		}
		finally
		{
			// cleanup
			__dapper__reader?.Dispose();
			if (__dapper__command is not null)
			{
				__dapper__command.Connection = default;
				__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Async_Multiple_input_cs_ValueWithCancellationTaskAsync_19, __dapper__command);
				__dapper__command?.Dispose();
			}
			if (__dapper__close) connection?.Close();
		}

		// command factory for ValueWithCancellationTaskAsync
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


	// available inactive command for ArrayAsync (interlocked)
	private static global::System.Data.Common.DbCommand? s___dapper__command_Samples_Async_Multiple_input_cs_ArrayAsync_22;

	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	public async partial global::System.Threading.Tasks.ValueTask<global::SomeType[]> ArrayAsync(global::System.Data.Common.DbConnection connection, int id, string name)
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
				await connection!.OpenAsync(global::System.Threading.CancellationToken.None).ConfigureAwait(false);
				__dapper__close = true;
			}

			// prepare command (excluding parameter values)
			if ((__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Async_Multiple_input_cs_ArrayAsync_22, null)) is null)
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
			__dapper__reader = await __dapper__command.ExecuteReaderAsync(__dapper__close ? (__dapper__behavior | global::System.Data.CommandBehavior.CloseConnection) : __dapper__behavior, global::System.Threading.CancellationToken.None).ConfigureAwait(false);
			__dapper__close = false; // performed via CommandBehavior

			// process single row
			global::SomeType[] __dapper__result;
			if (__dapper__reader.HasRows && await __dapper__reader.ReadAsync(global::System.Threading.CancellationToken.None).ConfigureAwait(false))
			{
				__dapper__result = global::Dapper.SqlMapper.GetRowParser<global::SomeType[]>(__dapper__reader).Invoke(__dapper__reader);
			}
			else
			{
				__dapper__result = default!;
			}
			// consume additional results (ensures errors from the server are observed)
			while (await __dapper__reader.NextResultAsync(global::System.Threading.CancellationToken.None).ConfigureAwait(false)) { }
			return __dapper__result;

			// TODO: post-process parameters

		}
		finally
		{
			// cleanup
			__dapper__reader?.Dispose();
			if (__dapper__command is not null)
			{
				__dapper__command.Connection = default;
				__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Async_Multiple_input_cs_ArrayAsync_22, __dapper__command);
				__dapper__command?.Dispose();
			}
			if (__dapper__close) connection?.Close();
		}

		// command factory for ArrayAsync
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


	// available inactive command for IListAsync (interlocked)
	private static global::System.Data.Common.DbCommand? s___dapper__command_Samples_Async_Multiple_input_cs_IListAsync_25;

	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	public partial global::System.Threading.Tasks.ValueTask<global::System.Collections.Generic.IList<global::SomeType>> IListAsync(global::System.Data.Common.DbConnection connection, int id, string name)
	{
		// locals
		global::System.Data.Common.DbCommand? __dapper__command = null;
		global::System.Data.Common.DbDataReader? __dapper__reader = null;
		bool __dapper__close = false;
		global::System.Collections.Generic.List<global::SomeType> __dapper__result;
		try
		{
			// prepare connection
			if (connection!.State == global::System.Data.ConnectionState.Closed)
			{
				connection!.Open();
				__dapper__close = true;
			}

			// prepare command (excluding parameter values)
			if ((__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Async_Multiple_input_cs_IListAsync_25, null)) is null)
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

			// process multiple rows
			__dapper__result = new global::System.Collections.Generic.List<global::SomeType>();
			if (__dapper__reader.HasRows)
			{
				var __dapper__parser = global::Dapper.SqlMapper.GetRowParser<global::SomeType>(__dapper__reader);
				while (__dapper__reader.Read())
				{
					__dapper__result.Add(__dapper__parser(__dapper__reader));
				}
			}
			// consume additional results (ensures errors from the server are observed)
			while (__dapper__reader.NextResult()) { }

			// TODO: post-process parameters

			// return rowset
			return __dapper__result;
		}
		finally
		{
			// cleanup
			__dapper__reader?.Dispose();
			if (__dapper__command is not null)
			{
				__dapper__command.Connection = default;
				__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Async_Multiple_input_cs_IListAsync_25, __dapper__command);
				__dapper__command?.Dispose();
			}
			if (__dapper__close) connection?.Close();
		}

		// command factory for IListAsync
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


	// available inactive command for ICollectionAsync (interlocked)
	private static global::System.Data.Common.DbCommand? s___dapper__command_Samples_Async_Multiple_input_cs_ICollectionAsync_28;

	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	public partial global::System.Threading.Tasks.ValueTask<global::System.Collections.Generic.ICollection<global::SomeType>> ICollectionAsync(global::System.Data.Common.DbConnection connection, int id, string name)
	{
		// locals
		global::System.Data.Common.DbCommand? __dapper__command = null;
		global::System.Data.Common.DbDataReader? __dapper__reader = null;
		bool __dapper__close = false;
		global::System.Collections.Generic.List<global::SomeType> __dapper__result;
		try
		{
			// prepare connection
			if (connection!.State == global::System.Data.ConnectionState.Closed)
			{
				connection!.Open();
				__dapper__close = true;
			}

			// prepare command (excluding parameter values)
			if ((__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Async_Multiple_input_cs_ICollectionAsync_28, null)) is null)
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

			// process multiple rows
			__dapper__result = new global::System.Collections.Generic.List<global::SomeType>();
			if (__dapper__reader.HasRows)
			{
				var __dapper__parser = global::Dapper.SqlMapper.GetRowParser<global::SomeType>(__dapper__reader);
				while (__dapper__reader.Read())
				{
					__dapper__result.Add(__dapper__parser(__dapper__reader));
				}
			}
			// consume additional results (ensures errors from the server are observed)
			while (__dapper__reader.NextResult()) { }

			// TODO: post-process parameters

			// return rowset
			return __dapper__result;
		}
		finally
		{
			// cleanup
			__dapper__reader?.Dispose();
			if (__dapper__command is not null)
			{
				__dapper__command.Connection = default;
				__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Async_Multiple_input_cs_ICollectionAsync_28, __dapper__command);
				__dapper__command?.Dispose();
			}
			if (__dapper__close) connection?.Close();
		}

		// command factory for ICollectionAsync
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


	// available inactive command for ImmutableArrayAsync (interlocked)
	private static global::System.Data.Common.DbCommand? s___dapper__command_Samples_Async_Multiple_input_cs_ImmutableArrayAsync_31;

	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	public partial global::System.Threading.Tasks.ValueTask<global::System.Collections.Immutable.ImmutableArray<global::SomeType>> ImmutableArrayAsync(global::System.Data.Common.DbConnection connection, int id, string name)
	{
		// locals
		global::System.Data.Common.DbCommand? __dapper__command = null;
		global::System.Data.Common.DbDataReader? __dapper__reader = null;
		bool __dapper__close = false;
#pragma warning disable CS0618
		global::Dapper.Internal.Collector<global::SomeType> __dapper__result = default;
#pragma warning restore CS0618
		try
		{
			// prepare connection
			if (connection!.State == global::System.Data.ConnectionState.Closed)
			{
				connection!.Open();
				__dapper__close = true;
			}

			// prepare command (excluding parameter values)
			if ((__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Async_Multiple_input_cs_ImmutableArrayAsync_31, null)) is null)
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

			// process multiple rows
			if (__dapper__reader.HasRows)
			{
				var __dapper__parser = global::Dapper.SqlMapper.GetRowParser<global::SomeType>(__dapper__reader);
				while (__dapper__reader.Read())
				{
					__dapper__result.Add(__dapper__parser(__dapper__reader));
				}
			}
			// consume additional results (ensures errors from the server are observed)
			while (__dapper__reader.NextResult()) { }

			// TODO: post-process parameters

			// return rowset
			return global::System.Collections.Immutable.ImmutableArray.Create<global::SomeType>(__dapper__result.GetBuffer(), 0, __dapper__result.Count);
		}
		finally
		{
			// cleanup
			__dapper__result.Dispose();
			__dapper__reader?.Dispose();
			if (__dapper__command is not null)
			{
				__dapper__command.Connection = default;
				__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Async_Multiple_input_cs_ImmutableArrayAsync_31, __dapper__command);
				__dapper__command?.Dispose();
			}
			if (__dapper__close) connection?.Close();
		}

		// command factory for ImmutableArrayAsync
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


	// available inactive command for ImmutableListAsync (interlocked)
	private static global::System.Data.Common.DbCommand? s___dapper__command_Samples_Async_Multiple_input_cs_ImmutableListAsync_34;

	[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
	public partial global::System.Threading.Tasks.ValueTask<global::System.Collections.Immutable.ImmutableList<global::SomeType>> ImmutableListAsync(global::System.Data.Common.DbConnection connection, int id, string name)
	{
		// locals
		global::System.Data.Common.DbCommand? __dapper__command = null;
		global::System.Data.Common.DbDataReader? __dapper__reader = null;
		bool __dapper__close = false;
#pragma warning disable CS0618
		global::Dapper.Internal.Collector<global::SomeType> __dapper__result = default;
#pragma warning restore CS0618
		try
		{
			// prepare connection
			if (connection!.State == global::System.Data.ConnectionState.Closed)
			{
				connection!.Open();
				__dapper__close = true;
			}

			// prepare command (excluding parameter values)
			if ((__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Async_Multiple_input_cs_ImmutableListAsync_34, null)) is null)
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

			// process multiple rows
			if (__dapper__reader.HasRows)
			{
				var __dapper__parser = global::Dapper.SqlMapper.GetRowParser<global::SomeType>(__dapper__reader);
				while (__dapper__reader.Read())
				{
					__dapper__result.Add(__dapper__parser(__dapper__reader));
				}
			}
			// consume additional results (ensures errors from the server are observed)
			while (__dapper__reader.NextResult()) { }

			// TODO: post-process parameters

			// return rowset
			switch (__dapper__result.Count)
			{
				case 0:return global::System.Collections.Immutable.ImmutableList<global::SomeType>.Empty;
				case 1:return global::System.Collections.Immutable.ImmutableList.Create<global::SomeType>(__dapper__result[0]);
				default:return global::System.Collections.Immutable.ImmutableList.CreateRange<global::SomeType>(__dapper__result.Segment);
			}
		}
		finally
		{
			// cleanup
			__dapper__result.Dispose();
			__dapper__reader?.Dispose();
			if (__dapper__command is not null)
			{
				__dapper__command.Connection = default;
				__dapper__command = global::System.Threading.Interlocked.Exchange(ref s___dapper__command_Samples_Async_Multiple_input_cs_ImmutableListAsync_34, __dapper__command);
				__dapper__command?.Dispose();
			}
			if (__dapper__close) connection?.Close();
		}

		// command factory for ImmutableListAsync
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
