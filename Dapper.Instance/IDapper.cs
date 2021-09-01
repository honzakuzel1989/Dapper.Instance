using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;

namespace Dapper.Instance
{
    public interface IDapper
    {
        //
        // Summary:
        //     Used to pass a IEnumerable<SqlDataRecord> as a TableValuedParameter.
        //
        // Parameters:
        //   list:
        //     The list of records to convert to TVPs.
        //
        //   typeName:
        //     The sql parameter type name.
        SqlMapper.ICustomQueryParameter AsTableValuedParameter<T>(IEnumerable<T> list, string typeName = null) where T : IDataRecord;
        //
        // Summary:
        //     Used to pass a DataTable as a Dapper.TableValuedParameter.
        //
        // Parameters:
        //   table:
        //     The System.Data.DataTable to create parameter for.
        //
        //   typeName:
        //     The name of the type parameter is for.
        SqlMapper.ICustomQueryParameter AsTableValuedParameter(DataTable table, string typeName = null);
        //
        // Summary:
        //     Execute parameterized SQL.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   sql:
        //     The SQL to execute for query.
        //
        //   param:
        //     The parameters to use for query.
        //
        //   transaction:
        //     The transaction to use for query.
        //
        //   commandTimeout:
        //     Number of seconds before command execution timeout.
        //
        //   commandType:
        //     Is it a stored proc or a batch?
        //
        // Returns:
        //     The number of rows affected.
        int Execute(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Execute parameterized SQL.
        //
        // Parameters:
        //   cnn:
        //     The connection to execute on.
        //
        //   command:
        //     The command to execute on connection.
        //
        // Returns:
        //     The number of rows affected.
        int Execute(IDbConnection cnn, CommandDefinition command);
        //
        // Summary:
        //     Execute a command asynchronously using Task.
        //
        // Parameters:
        //   cnn:
        //     The connection to execute on.
        //
        //   command:
        //     The command to execute on connection.
        //
        // Returns:
        //     The number of rows affected.
        Task<int> ExecuteAsync(IDbConnection cnn, CommandDefinition command);
        //
        // Summary:
        //     Execute a command asynchronously using Task.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   sql:
        //     The SQL to execute for query.
        //
        //   param:
        //     The parameters to use for query.
        //
        //   transaction:
        //     The transaction to use for query.
        //
        //   commandTimeout:
        //     Number of seconds before command execution timeout.
        //
        //   commandType:
        //     Is it a stored proc or a batch?
        //
        // Returns:
        //     The number of rows affected.
        Task<int> ExecuteAsync(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Execute parameterized SQL and return an System.Data.IDataReader.
        //
        // Parameters:
        //   cnn:
        //     The connection to execute on.
        //
        //   command:
        //     The command to execute.
        //
        //   commandBehavior:
        //     The System.Data.CommandBehavior flags for reader.
        //
        // Returns:
        //     An System.Data.IDataReader that can be used to iterate over the results of the
        //     SQL query.
        //
        // Remarks:
        //     is typically used when the results of a query are not processed by Dapper,
        //     for example, used to fill a System.Data.DataTable or DataSet.
        IDataReader ExecuteReader(IDbConnection cnn, CommandDefinition command, CommandBehavior commandBehavior);
        //
        // Summary:
        //     Execute parameterized SQL and return an System.Data.IDataReader.
        //
        // Parameters:
        //   cnn:
        //     The connection to execute on.
        //
        //   command:
        //     The command to execute.
        //
        // Returns:
        //     An System.Data.IDataReader that can be used to iterate over the results of the
        //     SQL query.
        //
        // Remarks:
        //     is typically used when the results of a query are not processed by Dapper,
        //     for example, used to fill a System.Data.DataTable or DataSet.
        IDataReader ExecuteReader(IDbConnection cnn, CommandDefinition command);
        //
        // Summary:
        //     Execute parameterized SQL and return an System.Data.IDataReader.
        //
        // Parameters:
        //   cnn:
        //     The connection to execute on.
        //
        //   sql:
        //     The SQL to execute.
        //
        //   param:
        //     The parameters to use for command.
        //
        //   transaction:
        //     The transaction to use for command.
        //
        //   commandTimeout:
        //     Number of seconds before command execution timeout.
        //
        //   commandType:
        //     Is it a stored proc or a batch?
        //
        // Returns:
        //     An System.Data.IDataReader that can be used to iterate over the results of the
        //     SQL query.
        //
        // Remarks:
        //     is typically used when the results of a query are not processed by Dapper,
        //     for example, used to fill a System.Data.DataTable or DataSet.
        IDataReader ExecuteReader(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Execute parameterized SQL and return an System.Data.IDataReader.
        //
        // Parameters:
        //   cnn:
        //     The connection to execute on.
        //
        //   command:
        //     The command to execute.
        //
        //   commandBehavior:
        //     The System.Data.CommandBehavior flags for reader.
        //
        // Returns:
        //     An System.Data.IDataReader that can be used to iterate over the results of the
        //     SQL query.
        //
        // Remarks:
        //     is typically used when the results of a query are not processed by Dapper,
        //     for example, used to fill a System.Data.DataTable or DataSet.
        Task<IDataReader> ExecuteReaderAsync(IDbConnection cnn, CommandDefinition command, CommandBehavior commandBehavior);
        //
        // Summary:
        //     Execute parameterized SQL and return a System.Data.Common.DbDataReader.
        //
        // Parameters:
        //   cnn:
        //     The connection to execute on.
        //
        //   command:
        //     The command to execute.
        Task<DbDataReader> ExecuteReaderAsync(DbConnection cnn, CommandDefinition command);
        //
        // Summary:
        //     Execute parameterized SQL and return an System.Data.IDataReader.
        //
        // Parameters:
        //   cnn:
        //     The connection to execute on.
        //
        //   command:
        //     The command to execute.
        //
        // Returns:
        //     An System.Data.IDataReader that can be used to iterate over the results of the
        //     SQL query.
        //
        // Remarks:
        //     is typically used when the results of a query are not processed by Dapper,
        //     for example, used to fill a System.Data.DataTable or DataSet.
        Task<IDataReader> ExecuteReaderAsync(IDbConnection cnn, CommandDefinition command);
        //
        // Summary:
        //     Execute parameterized SQL and return a System.Data.Common.DbDataReader.
        //
        // Parameters:
        //   cnn:
        //     The connection to execute on.
        //
        //   sql:
        //     The SQL to execute.
        //
        //   param:
        //     The parameters to use for command.
        //
        //   transaction:
        //     The transaction to use for command.
        //
        //   commandTimeout:
        //     Number of seconds before command execution timeout.
        //
        //   commandType:
        //     Is it a stored proc or a batch?
        Task<DbDataReader> ExecuteReaderAsync(DbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Execute parameterized SQL and return an System.Data.IDataReader.
        //
        // Parameters:
        //   cnn:
        //     The connection to execute on.
        //
        //   sql:
        //     The SQL to execute.
        //
        //   param:
        //     The parameters to use for command.
        //
        //   transaction:
        //     The transaction to use for command.
        //
        //   commandTimeout:
        //     Number of seconds before command execution timeout.
        //
        //   commandType:
        //     Is it a stored proc or a batch?
        //
        // Returns:
        //     An System.Data.IDataReader that can be used to iterate over the results of the
        //     SQL query.
        //
        // Remarks:
        //     is typically used when the results of a query are not processed by Dapper,
        //     for example, used to fill a System.Data.DataTable or DataSet.
        Task<IDataReader> ExecuteReaderAsync(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Execute parameterized SQL and return a System.Data.Common.DbDataReader.
        //
        // Parameters:
        //   cnn:
        //     The connection to execute on.
        //
        //   command:
        //     The command to execute.
        //
        //   commandBehavior:
        //     The System.Data.CommandBehavior flags for reader.
        Task<DbDataReader> ExecuteReaderAsync(DbConnection cnn, CommandDefinition command, CommandBehavior commandBehavior);
        //
        // Summary:
        //     Execute parameterized SQL that selects a single value.
        //
        // Parameters:
        //   cnn:
        //     The connection to execute on.
        //
        //   sql:
        //     The SQL to execute.
        //
        //   param:
        //     The parameters to use for command.
        //
        //   transaction:
        //     The transaction to use for command.
        //
        //   commandTimeout:
        //     Number of seconds before command execution timeout.
        //
        //   commandType:
        //     Is it a stored proc or a batch?
        //
        // Returns:
        //     The first cell selected as System.Object.
        object ExecuteScalar(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Execute parameterized SQL that selects a single value.
        //
        // Parameters:
        //   cnn:
        //     The connection to execute on.
        //
        //   sql:
        //     The SQL to execute.
        //
        //   param:
        //     The parameters to use for command.
        //
        //   transaction:
        //     The transaction to use for command.
        //
        //   commandTimeout:
        //     Number of seconds before command execution timeout.
        //
        //   commandType:
        //     Is it a stored proc or a batch?
        //
        // Type parameters:
        //   T:
        //     The type to return.
        //
        // Returns:
        //     The first cell returned, as T.
        T ExecuteScalar<T>(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Execute parameterized SQL that selects a single value.
        //
        // Parameters:
        //   cnn:
        //     The connection to execute on.
        //
        //   command:
        //     The command to execute.
        //
        // Type parameters:
        //   T:
        //     The type to return.
        //
        // Returns:
        //     The first cell selected as T.
        T ExecuteScalar<T>(IDbConnection cnn, CommandDefinition command);
        //
        // Summary:
        //     Execute parameterized SQL that selects a single value.
        //
        // Parameters:
        //   cnn:
        //     The connection to execute on.
        //
        //   command:
        //     The command to execute.
        //
        // Returns:
        //     The first cell selected as System.Object.
        object ExecuteScalar(IDbConnection cnn, CommandDefinition command);
        //
        // Summary:
        //     Execute parameterized SQL that selects a single value.
        //
        // Parameters:
        //   cnn:
        //     The connection to execute on.
        //
        //   command:
        //     The command to execute.
        //
        // Returns:
        //     The first cell selected as System.Object.
        Task<object> ExecuteScalarAsync(IDbConnection cnn, CommandDefinition command);
        //
        // Summary:
        //     Execute parameterized SQL that selects a single value.
        //
        // Parameters:
        //   cnn:
        //     The connection to execute on.
        //
        //   sql:
        //     The SQL to execute.
        //
        //   param:
        //     The parameters to use for command.
        //
        //   transaction:
        //     The transaction to use for command.
        //
        //   commandTimeout:
        //     Number of seconds before command execution timeout.
        //
        //   commandType:
        //     Is it a stored proc or a batch?
        //
        // Type parameters:
        //   T:
        //     The type to return.
        //
        // Returns:
        //     The first cell returned, as T.
        Task<T> ExecuteScalarAsync<T>(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Execute parameterized SQL that selects a single value.
        //
        // Parameters:
        //   cnn:
        //     The connection to execute on.
        //
        //   sql:
        //     The SQL to execute.
        //
        //   param:
        //     The parameters to use for command.
        //
        //   transaction:
        //     The transaction to use for command.
        //
        //   commandTimeout:
        //     Number of seconds before command execution timeout.
        //
        //   commandType:
        //     Is it a stored proc or a batch?
        //
        // Returns:
        //     The first cell returned, as System.Object.
        Task<object> ExecuteScalarAsync(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Execute parameterized SQL that selects a single value.
        //
        // Parameters:
        //   cnn:
        //     The connection to execute on.
        //
        //   command:
        //     The command to execute.
        //
        // Type parameters:
        //   T:
        //     The type to return.
        //
        // Returns:
        //     The first cell selected as T.
        Task<T> ExecuteScalarAsync<T>(IDbConnection cnn, CommandDefinition command);
        //
        // Summary:
        //     Gets the row parser for a specific row on a data reader. allows for type
        //     switching every row based on, for example, a TypeId column. You could return
        //     a collection of the base type but have each more specific.
        //
        // Parameters:
        //   reader:
        //     The data reader to get the parser for the current row from.
        //
        //   concreteType:
        //     The type to get the parser for.
        //
        //   startIndex:
        //     The start column index of the object (default: 0).
        //
        //   length:
        //     The length of columns to read (default: -1 = all fields following startIndex).
        //
        //   returnNullIfFirstMissing:
        //     Return null if we can't find the first column? (default: false).
        //
        // Type parameters:
        //   T:
        //     The type of results to return.
        //
        // Returns:
        //     A parser for specific object from row.
        Func<IDataReader, T> GetRowParser<T>(IDataReader reader, Type concreteType = null, int startIndex = 0, int length = -1, bool returnNullIfFirstMissing = false);
        //
        // Summary:
        //     Gets the row parser for a specific row on a data reader. allows for type
        //     switching every row based on, for example, a TypeId column. You could return
        //     a collection of the base type but have each more specific.
        //
        // Parameters:
        //   reader:
        //     The data reader to get the parser for the current row from
        //
        //   type:
        //     The type to get the parser for
        //
        //   startIndex:
        //     The start column index of the object (default 0)
        //
        //   length:
        //     The length of columns to read (default -1 = all fields following startIndex)
        //
        //   returnNullIfFirstMissing:
        //     Return null if we can't find the first column? (default false)
        //
        // Returns:
        //     A parser for specific object from row.
        Func<IDataReader, object> GetRowParser(IDataReader reader, Type type, int startIndex = 0, int length = -1, bool returnNullIfFirstMissing = false);
        //
        // Summary:
        //     Parses a data reader to a sequence of data of the supplied type (as object).
        //     Used for deserializing a reader without a connection, etc.
        //
        // Parameters:
        //   reader:
        //     The data reader to parse results from.
        //
        //   type:
        //     The type to parse from the reader.
        IEnumerable<object> Parse(IDataReader reader, Type type);
        //
        // Summary:
        //     Parses a data reader to a sequence of data of the supplied type. Used for deserializing
        //     a reader without a connection, etc.
        //
        // Parameters:
        //   reader:
        //     The data reader to parse results from.
        //
        // Type parameters:
        //   T:
        //     The type to parse from the reader.
        IEnumerable<T> Parse<T>(IDataReader reader);
        //
        // Summary:
        //     Parses a data reader to a sequence of dynamic. Used for deserializing a reader
        //     without a connection, etc.
        //
        // Parameters:
        //   reader:
        //     The data reader to parse results from.
        IEnumerable<dynamic> Parse(IDataReader reader);
        //
        // Summary:
        //     Executes a single-row query, returning the data typed as type.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   type:
        //     The type to return.
        //
        //   sql:
        //     The SQL to execute for the query.
        //
        //   param:
        //     The parameters to pass, if any.
        //
        //   transaction:
        //     The transaction to use, if any.
        //
        //   buffered:
        //     Whether to buffer results in memory.
        //
        //   commandTimeout:
        //     The command timeout (in seconds).
        //
        //   commandType:
        //     The type of command to execute.
        //
        // Returns:
        //     A sequence of data of the supplied type; if a basic type (int, string, etc) is
        //     queried then the data from the first column in assumed, otherwise an instance
        //     is created per row, and a direct column-name===member-name mapping is assumed
        //     (case insensitive).
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     type is null.
        IEnumerable<object> Query(IDbConnection cnn, Type type, string sql, object param = null, IDbTransaction transaction = null, bool buffered = true, int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Executes a query, returning the data typed as T.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   sql:
        //     The SQL to execute for the query.
        //
        //   param:
        //     The parameters to pass, if any.
        //
        //   transaction:
        //     The transaction to use, if any.
        //
        //   buffered:
        //     Whether to buffer results in memory.
        //
        //   commandTimeout:
        //     The command timeout (in seconds).
        //
        //   commandType:
        //     The type of command to execute.
        //
        // Type parameters:
        //   T:
        //     The type of results to return.
        //
        // Returns:
        //     A sequence of data of the supplied type; if a basic type (int, string, etc) is
        //     queried then the data from the first column is assumed, otherwise an instance
        //     is created per row, and a direct column-name===member-name mapping is assumed
        //     (case insensitive).
        IEnumerable<T> Query<T>(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, bool buffered = true, int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Perform a multi-mapping query with an arbitrary number of input types. returns
        //     a single type, combined from the raw types via map.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   sql:
        //     The SQL to execute for query.
        //
        //   types:
        //     Array of types in the recordset.
        //
        //   map:
        //     The function to map row types to the return type.
        //
        //   param:
        //     The parameters to use for query.
        //
        //   transaction:
        //     The transaction to use for query.
        //
        //   buffered:
        //     Whether to buffer the results in memory.
        //
        //   splitOn:
        //     The field we should split and read the second object from (default: "Id").
        //
        //   commandTimeout:
        //     Number of seconds before command execution timeout.
        //
        //   commandType:
        //     Is it a stored proc or a batch?
        //
        // Type parameters:
        //   TReturn:
        //     The combined type to return.
        //
        // Returns:
        //     An enumerable of TReturn.
        IEnumerable<TReturn> Query<TReturn>(IDbConnection cnn, string sql, Type[] types, Func<object[], TReturn> map, object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Perform a multi-mapping query with 7 input types. If you need more types -> use
        //     Query with Type[] parameter. returns a single type, combined from the raw
        //     types via map.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   sql:
        //     The SQL to execute for query.
        //
        //   map:
        //     The function to map row types to the return type.
        //
        //   param:
        //     The parameters to use for query.
        //
        //   transaction:
        //     The transaction to use for query.
        //
        //   buffered:
        //     Whether to buffer the results in memory.
        //
        //   splitOn:
        //     The field we should split and read the second object from (default: "Id").
        //
        //   commandTimeout:
        //     Number of seconds before command execution timeout.
        //
        //   commandType:
        //     Is it a stored proc or a batch?
        //
        // Type parameters:
        //   TFirst:
        //     The first type in the recordset.
        //
        //   TSecond:
        //     The second type in the recordset.
        //
        //   TThird:
        //     The third type in the recordset.
        //
        //   TFourth:
        //     The fourth type in the recordset.
        //
        //   TFifth:
        //     The fifth type in the recordset.
        //
        //   TSixth:
        //     The sixth type in the recordset.
        //
        //   TSeventh:
        //     The seventh type in the recordset.
        //
        //   TReturn:
        //     The combined type to return.
        //
        // Returns:
        //     An enumerable of TReturn.
        IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn>(IDbConnection cnn, string sql, Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn> map, object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Perform a multi-mapping query with 6 input types. returns a single type,
        //     combined from the raw types via map.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   sql:
        //     The SQL to execute for query.
        //
        //   map:
        //     The function to map row types to the return type.
        //
        //   param:
        //     The parameters to use for query.
        //
        //   transaction:
        //     The transaction to use for query.
        //
        //   buffered:
        //     Whether to buffer the results in memory.
        //
        //   splitOn:
        //     The field we should split and read the second object from (default: "Id").
        //
        //   commandTimeout:
        //     Number of seconds before command execution timeout.
        //
        //   commandType:
        //     Is it a stored proc or a batch?
        //
        // Type parameters:
        //   TFirst:
        //     The first type in the recordset.
        //
        //   TSecond:
        //     The second type in the recordset.
        //
        //   TThird:
        //     The third type in the recordset.
        //
        //   TFourth:
        //     The fourth type in the recordset.
        //
        //   TFifth:
        //     The fifth type in the recordset.
        //
        //   TSixth:
        //     The sixth type in the recordset.
        //
        //   TReturn:
        //     The combined type to return.
        //
        // Returns:
        //     An enumerable of TReturn.
        IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(IDbConnection cnn, string sql, Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn> map, object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Perform a multi-mapping query with 2 input types. returns a single type,
        //     combined from the raw types via map.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   sql:
        //     The SQL to execute for query.
        //
        //   map:
        //     The function to map row types to the return type.
        //
        //   param:
        //     The parameters to use for query.
        //
        //   transaction:
        //     The transaction to use for query.
        //
        //   buffered:
        //     Whether to buffer the results in memory.
        //
        //   splitOn:
        //     The field we should split and read the second object from (default: "Id").
        //
        //   commandTimeout:
        //     Number of seconds before command execution timeout.
        //
        //   commandType:
        //     Is it a stored proc or a batch?
        //
        // Type parameters:
        //   TFirst:
        //     The first type in the recordset.
        //
        //   TSecond:
        //     The second type in the recordset.
        //
        //   TReturn:
        //     The combined type to return.
        //
        // Returns:
        //     An enumerable of TReturn.
        IEnumerable<TReturn> Query<TFirst, TSecond, TReturn>(IDbConnection cnn, string sql, Func<TFirst, TSecond, TReturn> map, object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Perform a multi-mapping query with 5 input types. returns a single type,
        //     combined from the raw types via map.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   sql:
        //     The SQL to execute for query.
        //
        //   map:
        //     The function to map row types to the return type.
        //
        //   param:
        //     The parameters to use for query.
        //
        //   transaction:
        //     The transaction to use for query.
        //
        //   buffered:
        //     Whether to buffer the results in memory.
        //
        //   splitOn:
        //     The field we should split and read the second object from (default: "Id").
        //
        //   commandTimeout:
        //     Number of seconds before command execution timeout.
        //
        //   commandType:
        //     Is it a stored proc or a batch?
        //
        // Type parameters:
        //   TFirst:
        //     The first type in the recordset.
        //
        //   TSecond:
        //     The second type in the recordset.
        //
        //   TThird:
        //     The third type in the recordset.
        //
        //   TFourth:
        //     The fourth type in the recordset.
        //
        //   TFifth:
        //     The fifth type in the recordset.
        //
        //   TReturn:
        //     The combined type to return.
        //
        // Returns:
        //     An enumerable of TReturn.
        IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(IDbConnection cnn, string sql, Func<TFirst, TSecond, TThird, TFourth, TFifth, TReturn> map, object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Perform a multi-mapping query with 4 input types. returns a single type,
        //     combined from the raw types via map.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   sql:
        //     The SQL to execute for query.
        //
        //   map:
        //     The function to map row types to the return type.
        //
        //   param:
        //     The parameters to use for query.
        //
        //   transaction:
        //     The transaction to use for query.
        //
        //   buffered:
        //     Whether to buffer the results in memory.
        //
        //   splitOn:
        //     The field we should split and read the second object from (default: "Id").
        //
        //   commandTimeout:
        //     Number of seconds before command execution timeout.
        //
        //   commandType:
        //     Is it a stored proc or a batch?
        //
        // Type parameters:
        //   TFirst:
        //     The first type in the recordset.
        //
        //   TSecond:
        //     The second type in the recordset.
        //
        //   TThird:
        //     The third type in the recordset.
        //
        //   TFourth:
        //     The fourth type in the recordset.
        //
        //   TReturn:
        //     The combined type to return.
        //
        // Returns:
        //     An enumerable of TReturn.
        IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TReturn>(IDbConnection cnn, string sql, Func<TFirst, TSecond, TThird, TFourth, TReturn> map, object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Return a sequence of dynamic objects with properties matching the columns.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   sql:
        //     The SQL to execute for the query.
        //
        //   param:
        //     The parameters to pass, if any.
        //
        //   transaction:
        //     The transaction to use, if any.
        //
        //   buffered:
        //     Whether to buffer the results in memory.
        //
        //   commandTimeout:
        //     The command timeout (in seconds).
        //
        //   commandType:
        //     The type of command to execute.
        //
        // Remarks:
        //     Note: each row can be accessed via "dynamic", or by casting to an IDictionary<string,object>
        IEnumerable<dynamic> Query(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, bool buffered = true, int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Perform a multi-mapping query with 3 input types. returns a single type,
        //     combined from the raw types via map.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   sql:
        //     The SQL to execute for query.
        //
        //   map:
        //     The function to map row types to the return type.
        //
        //   param:
        //     The parameters to use for query.
        //
        //   transaction:
        //     The transaction to use for query.
        //
        //   buffered:
        //     Whether to buffer the results in memory.
        //
        //   splitOn:
        //     The field we should split and read the second object from (default: "Id").
        //
        //   commandTimeout:
        //     Number of seconds before command execution timeout.
        //
        //   commandType:
        //     Is it a stored proc or a batch?
        //
        // Type parameters:
        //   TFirst:
        //     The first type in the recordset.
        //
        //   TSecond:
        //     The second type in the recordset.
        //
        //   TThird:
        //     The third type in the recordset.
        //
        //   TReturn:
        //     The combined type to return.
        //
        // Returns:
        //     An enumerable of TReturn.
        IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TReturn>(IDbConnection cnn, string sql, Func<TFirst, TSecond, TThird, TReturn> map, object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Executes a query, returning the data typed as T.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   command:
        //     The command used to query on connection.
        //
        // Type parameters:
        //   T:
        //     The type of results to return.
        //
        // Returns:
        //     A sequence of data of T; if a basic type (int, string, etc) is queried then the
        //     data from the first column in assumed, otherwise an instance is created per row,
        //     and a direct column-name===member-name mapping is assumed (case insensitive).
        IEnumerable<T> Query<T>(IDbConnection cnn, CommandDefinition command);
        //
        // Summary:
        //     Perform an asynchronous multi-mapping query with 2 input types. returns
        //     a single type, combined from the raw types via map.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   splitOn:
        //     The field we should split and read the second object from (default: "Id").
        //
        //   command:
        //     The command to execute.
        //
        //   map:
        //     The function to map row types to the return type.
        //
        // Type parameters:
        //   TFirst:
        //     The first type in the recordset.
        //
        //   TSecond:
        //     The second type in the recordset.
        //
        //   TReturn:
        //     The combined type to return.
        //
        // Returns:
        //     An enumerable of TReturn.
        Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TReturn>(IDbConnection cnn, CommandDefinition command, Func<TFirst, TSecond, TReturn> map, string splitOn = "Id");
        //
        // Summary:
        //     Perform an asynchronous multi-mapping query with 2 input types. returns
        //     a single type, combined from the raw types via map.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   sql:
        //     The SQL to execute for query.
        //
        //   map:
        //     The function to map row types to the return type.
        //
        //   param:
        //     The parameters to use for query.
        //
        //   transaction:
        //     The transaction to use for query.
        //
        //   buffered:
        //     Whether to buffer the results in memory.
        //
        //   splitOn:
        //     The field we should split and read the second object from (default: "Id").
        //
        //   commandTimeout:
        //     Number of seconds before command execution timeout.
        //
        //   commandType:
        //     Is it a stored proc or a batch?
        //
        // Type parameters:
        //   TFirst:
        //     The first type in the recordset.
        //
        //   TSecond:
        //     The second type in the recordset.
        //
        //   TReturn:
        //     The combined type to return.
        //
        // Returns:
        //     An enumerable of TReturn.
        Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TReturn>(IDbConnection cnn, string sql, Func<TFirst, TSecond, TReturn> map, object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Execute a query asynchronously using Task.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   sql:
        //     The SQL to execute for the query.
        //
        //   param:
        //     The parameters to pass, if any.
        //
        //   transaction:
        //     The transaction to use, if any.
        //
        //   commandTimeout:
        //     The command timeout (in seconds).
        //
        //   commandType:
        //     The type of command to execute.
        //
        // Remarks:
        //     Note: each row can be accessed via "dynamic", or by casting to an IDictionary<string,object>
        Task<IEnumerable<dynamic>> QueryAsync(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Execute a query asynchronously using Task.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   command:
        //     The command used to query on connection.
        //
        // Remarks:
        //     Note: each row can be accessed via "dynamic", or by casting to an IDictionary<string,object>
        Task<IEnumerable<dynamic>> QueryAsync(IDbConnection cnn, CommandDefinition command);
        //
        // Summary:
        //     Perform an asynchronous multi-mapping query with 3 input types. returns
        //     a single type, combined from the raw types via map.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   sql:
        //     The SQL to execute for query.
        //
        //   map:
        //     The function to map row types to the return type.
        //
        //   param:
        //     The parameters to use for query.
        //
        //   transaction:
        //     The transaction to use for query.
        //
        //   buffered:
        //     Whether to buffer the results in memory.
        //
        //   splitOn:
        //     The field we should split and read the second object from (default: "Id").
        //
        //   commandTimeout:
        //     Number of seconds before command execution timeout.
        //
        //   commandType:
        //     Is it a stored proc or a batch?
        //
        // Type parameters:
        //   TFirst:
        //     The first type in the recordset.
        //
        //   TSecond:
        //     The second type in the recordset.
        //
        //   TThird:
        //     The third type in the recordset.
        //
        //   TReturn:
        //     The combined type to return.
        //
        // Returns:
        //     An enumerable of TReturn.
        Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TReturn>(IDbConnection cnn, string sql, Func<TFirst, TSecond, TThird, TReturn> map, object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Perform an asynchronous multi-mapping query with 3 input types. returns
        //     a single type, combined from the raw types via map.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   splitOn:
        //     The field we should split and read the second object from (default: "Id").
        //
        //   command:
        //     The command to execute.
        //
        //   map:
        //     The function to map row types to the return type.
        //
        // Type parameters:
        //   TFirst:
        //     The first type in the recordset.
        //
        //   TSecond:
        //     The second type in the recordset.
        //
        //   TThird:
        //     The third type in the recordset.
        //
        //   TReturn:
        //     The combined type to return.
        //
        // Returns:
        //     An enumerable of TReturn.
        Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TReturn>(IDbConnection cnn, CommandDefinition command, Func<TFirst, TSecond, TThird, TReturn> map, string splitOn = "Id");
        //
        // Summary:
        //     Perform an asynchronous multi-mapping query with 4 input types. returns
        //     a single type, combined from the raw types via map.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   sql:
        //     The SQL to execute for query.
        //
        //   map:
        //     The function to map row types to the return type.
        //
        //   param:
        //     The parameters to use for query.
        //
        //   transaction:
        //     The transaction to use for query.
        //
        //   buffered:
        //     Whether to buffer the results in memory.
        //
        //   splitOn:
        //     The field we should split and read the second object from (default: "Id").
        //
        //   commandTimeout:
        //     Number of seconds before command execution timeout.
        //
        //   commandType:
        //     Is it a stored proc or a batch?
        //
        // Type parameters:
        //   TFirst:
        //     The first type in the recordset.
        //
        //   TSecond:
        //     The second type in the recordset.
        //
        //   TThird:
        //     The third type in the recordset.
        //
        //   TFourth:
        //     The fourth type in the recordset.
        //
        //   TReturn:
        //     The combined type to return.
        //
        // Returns:
        //     An enumerable of TReturn.
        Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TReturn>(IDbConnection cnn, string sql, Func<TFirst, TSecond, TThird, TFourth, TReturn> map, object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Perform an asynchronous multi-mapping query with 4 input types. returns
        //     a single type, combined from the raw types via map.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   splitOn:
        //     The field we should split and read the second object from (default: "Id").
        //
        //   command:
        //     The command to execute.
        //
        //   map:
        //     The function to map row types to the return type.
        //
        // Type parameters:
        //   TFirst:
        //     The first type in the recordset.
        //
        //   TSecond:
        //     The second type in the recordset.
        //
        //   TThird:
        //     The third type in the recordset.
        //
        //   TFourth:
        //     The fourth type in the recordset.
        //
        //   TReturn:
        //     The combined type to return.
        //
        // Returns:
        //     An enumerable of TReturn.
        Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TReturn>(IDbConnection cnn, CommandDefinition command, Func<TFirst, TSecond, TThird, TFourth, TReturn> map, string splitOn = "Id");
        //
        // Summary:
        //     Execute a query asynchronously using Task.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   type:
        //     The type to return.
        //
        //   command:
        //     The command used to query on connection.
        Task<IEnumerable<object>> QueryAsync(IDbConnection cnn, Type type, CommandDefinition command);
        //
        // Summary:
        //     Execute a query asynchronously using Task.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   sql:
        //     The SQL to execute for the query.
        //
        //   param:
        //     The parameters to pass, if any.
        //
        //   transaction:
        //     The transaction to use, if any.
        //
        //   commandTimeout:
        //     The command timeout (in seconds).
        //
        //   commandType:
        //     The type of command to execute.
        //
        // Type parameters:
        //   T:
        //     The type of results to return.
        //
        // Returns:
        //     A sequence of data of T; if a basic type (int, string, etc) is queried then the
        //     data from the first column in assumed, otherwise an instance is created per row,
        //     and a direct column-name===member-name mapping is assumed (case insensitive).
        Task<IEnumerable<T>> QueryAsync<T>(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Perform an asynchronous multi-mapping query with 5 input types. returns
        //     a single type, combined from the raw types via map.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   sql:
        //     The SQL to execute for query.
        //
        //   map:
        //     The function to map row types to the return type.
        //
        //   param:
        //     The parameters to use for query.
        //
        //   transaction:
        //     The transaction to use for query.
        //
        //   buffered:
        //     Whether to buffer the results in memory.
        //
        //   splitOn:
        //     The field we should split and read the second object from (default: "Id").
        //
        //   commandTimeout:
        //     Number of seconds before command execution timeout.
        //
        //   commandType:
        //     Is it a stored proc or a batch?
        //
        // Type parameters:
        //   TFirst:
        //     The first type in the recordset.
        //
        //   TSecond:
        //     The second type in the recordset.
        //
        //   TThird:
        //     The third type in the recordset.
        //
        //   TFourth:
        //     The fourth type in the recordset.
        //
        //   TFifth:
        //     The fifth type in the recordset.
        //
        //   TReturn:
        //     The combined type to return.
        //
        // Returns:
        //     An enumerable of TReturn.
        Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(IDbConnection cnn, string sql, Func<TFirst, TSecond, TThird, TFourth, TFifth, TReturn> map, object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Perform an asynchronous multi-mapping query with 6 input types. returns
        //     a single type, combined from the raw types via map.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   sql:
        //     The SQL to execute for query.
        //
        //   map:
        //     The function to map row types to the return type.
        //
        //   param:
        //     The parameters to use for query.
        //
        //   transaction:
        //     The transaction to use for query.
        //
        //   buffered:
        //     Whether to buffer the results in memory.
        //
        //   splitOn:
        //     The field we should split and read the second object from (default: "Id").
        //
        //   commandTimeout:
        //     Number of seconds before command execution timeout.
        //
        //   commandType:
        //     Is it a stored proc or a batch?
        //
        // Type parameters:
        //   TFirst:
        //     The first type in the recordset.
        //
        //   TSecond:
        //     The second type in the recordset.
        //
        //   TThird:
        //     The third type in the recordset.
        //
        //   TFourth:
        //     The fourth type in the recordset.
        //
        //   TFifth:
        //     The fifth type in the recordset.
        //
        //   TSixth:
        //     The sixth type in the recordset.
        //
        //   TReturn:
        //     The combined type to return.
        //
        // Returns:
        //     An enumerable of TReturn.
        Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(IDbConnection cnn, string sql, Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn> map, object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Perform an asynchronous multi-mapping query with 6 input types. returns
        //     a single type, combined from the raw types via map.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   splitOn:
        //     The field we should split and read the second object from (default: "Id").
        //
        //   command:
        //     The command to execute.
        //
        //   map:
        //     The function to map row types to the return type.
        //
        // Type parameters:
        //   TFirst:
        //     The first type in the recordset.
        //
        //   TSecond:
        //     The second type in the recordset.
        //
        //   TThird:
        //     The third type in the recordset.
        //
        //   TFourth:
        //     The fourth type in the recordset.
        //
        //   TFifth:
        //     The fifth type in the recordset.
        //
        //   TSixth:
        //     The sixth type in the recordset.
        //
        //   TReturn:
        //     The combined type to return.
        //
        // Returns:
        //     An enumerable of TReturn.
        Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(IDbConnection cnn, CommandDefinition command, Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn> map, string splitOn = "Id");
        //
        // Summary:
        //     Perform an asynchronous multi-mapping query with 7 input types. returns
        //     a single type, combined from the raw types via map.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   sql:
        //     The SQL to execute for query.
        //
        //   map:
        //     The function to map row types to the return type.
        //
        //   param:
        //     The parameters to use for query.
        //
        //   transaction:
        //     The transaction to use for query.
        //
        //   buffered:
        //     Whether to buffer the results in memory.
        //
        //   splitOn:
        //     The field we should split and read the second object from (default: "Id").
        //
        //   commandTimeout:
        //     Number of seconds before command execution timeout.
        //
        //   commandType:
        //     Is it a stored proc or a batch?
        //
        // Type parameters:
        //   TFirst:
        //     The first type in the recordset.
        //
        //   TSecond:
        //     The second type in the recordset.
        //
        //   TThird:
        //     The third type in the recordset.
        //
        //   TFourth:
        //     The fourth type in the recordset.
        //
        //   TFifth:
        //     The fifth type in the recordset.
        //
        //   TSixth:
        //     The sixth type in the recordset.
        //
        //   TSeventh:
        //     The seventh type in the recordset.
        //
        //   TReturn:
        //     The combined type to return.
        //
        // Returns:
        //     An enumerable of TReturn.
        Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn>(IDbConnection cnn, string sql, Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn> map, object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Perform an asynchronous multi-mapping query with 7 input types. returns
        //     a single type, combined from the raw types via map.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   splitOn:
        //     The field we should split and read the second object from (default: "Id").
        //
        //   command:
        //     The command to execute.
        //
        //   map:
        //     The function to map row types to the return type.
        //
        // Type parameters:
        //   TFirst:
        //     The first type in the recordset.
        //
        //   TSecond:
        //     The second type in the recordset.
        //
        //   TThird:
        //     The third type in the recordset.
        //
        //   TFourth:
        //     The fourth type in the recordset.
        //
        //   TFifth:
        //     The fifth type in the recordset.
        //
        //   TSixth:
        //     The sixth type in the recordset.
        //
        //   TSeventh:
        //     The seventh type in the recordset.
        //
        //   TReturn:
        //     The combined type to return.
        //
        // Returns:
        //     An enumerable of TReturn.
        Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn>(IDbConnection cnn, CommandDefinition command, Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn> map, string splitOn = "Id");
        //
        // Summary:
        //     Perform an asynchronous multi-mapping query with an arbitrary number of input
        //     types. returns a single type, combined from the raw types via map.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   sql:
        //     The SQL to execute for query.
        //
        //   types:
        //     Array of types in the recordset.
        //
        //   map:
        //     The function to map row types to the return type.
        //
        //   param:
        //     The parameters to use for query.
        //
        //   transaction:
        //     The transaction to use for query.
        //
        //   buffered:
        //     Whether to buffer the results in memory.
        //
        //   splitOn:
        //     The field we should split and read the second object from (default: "Id").
        //
        //   commandTimeout:
        //     Number of seconds before command execution timeout.
        //
        //   commandType:
        //     Is it a stored proc or a batch?
        //
        // Type parameters:
        //   TReturn:
        //     The combined type to return.
        //
        // Returns:
        //     An enumerable of TReturn.
        Task<IEnumerable<TReturn>> QueryAsync<TReturn>(IDbConnection cnn, string sql, Type[] types, Func<object[], TReturn> map, object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Execute a query asynchronously using Task.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   type:
        //     The type to return.
        //
        //   sql:
        //     The SQL to execute for the query.
        //
        //   param:
        //     The parameters to pass, if any.
        //
        //   transaction:
        //     The transaction to use, if any.
        //
        //   commandTimeout:
        //     The command timeout (in seconds).
        //
        //   commandType:
        //     The type of command to execute.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     type is null.
        Task<IEnumerable<object>> QueryAsync(IDbConnection cnn, Type type, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Perform an asynchronous multi-mapping query with 5 input types. returns
        //     a single type, combined from the raw types via map.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   splitOn:
        //     The field we should split and read the second object from (default: "Id").
        //
        //   command:
        //     The command to execute.
        //
        //   map:
        //     The function to map row types to the return type.
        //
        // Type parameters:
        //   TFirst:
        //     The first type in the recordset.
        //
        //   TSecond:
        //     The second type in the recordset.
        //
        //   TThird:
        //     The third type in the recordset.
        //
        //   TFourth:
        //     The fourth type in the recordset.
        //
        //   TFifth:
        //     The fifth type in the recordset.
        //
        //   TReturn:
        //     The combined type to return.
        //
        // Returns:
        //     An enumerable of TReturn.
        Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(IDbConnection cnn, CommandDefinition command, Func<TFirst, TSecond, TThird, TFourth, TFifth, TReturn> map, string splitOn = "Id");
        //
        // Summary:
        //     Execute a query asynchronously using Task.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   command:
        //     The command used to query on connection.
        //
        // Type parameters:
        //   T:
        //     The type to return.
        //
        // Returns:
        //     A sequence of data of T; if a basic type (int, string, etc) is queried then the
        //     data from the first column in assumed, otherwise an instance is created per row,
        //     and a direct column-name===member-name mapping is assumed (case insensitive).
        Task<IEnumerable<T>> QueryAsync<T>(IDbConnection cnn, CommandDefinition command);
        //
        // Summary:
        //     Executes a query, returning the data typed as T.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   command:
        //     The command used to query on connection.
        //
        // Type parameters:
        //   T:
        //     The type of results to return.
        //
        // Returns:
        //     A single instance or null of the supplied type; if a basic type (int, string,
        //     etc) is queried then the data from the first column in assumed, otherwise an
        //     instance is created per row, and a direct column-name===member-name mapping is
        //     assumed (case insensitive).
        T QueryFirst<T>(IDbConnection cnn, CommandDefinition command);
        //
        // Summary:
        //     Executes a single-row query, returning the data typed as type.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   type:
        //     The type to return.
        //
        //   sql:
        //     The SQL to execute for the query.
        //
        //   param:
        //     The parameters to pass, if any.
        //
        //   transaction:
        //     The transaction to use, if any.
        //
        //   commandTimeout:
        //     The command timeout (in seconds).
        //
        //   commandType:
        //     The type of command to execute.
        //
        // Returns:
        //     A sequence of data of the supplied type; if a basic type (int, string, etc) is
        //     queried then the data from the first column in assumed, otherwise an instance
        //     is created per row, and a direct column-name===member-name mapping is assumed
        //     (case insensitive).
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     type is null.
        object QueryFirst(IDbConnection cnn, Type type, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Executes a single-row query, returning the data typed as T.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   sql:
        //     The SQL to execute for the query.
        //
        //   param:
        //     The parameters to pass, if any.
        //
        //   transaction:
        //     The transaction to use, if any.
        //
        //   commandTimeout:
        //     The command timeout (in seconds).
        //
        //   commandType:
        //     The type of command to execute.
        //
        // Type parameters:
        //   T:
        //     The type of result to return.
        //
        // Returns:
        //     A sequence of data of the supplied type; if a basic type (int, string, etc) is
        //     queried then the data from the first column in assumed, otherwise an instance
        //     is created per row, and a direct column-name===member-name mapping is assumed
        //     (case insensitive).
        T QueryFirst<T>(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Return a dynamic object with properties matching the columns.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   sql:
        //     The SQL to execute for the query.
        //
        //   param:
        //     The parameters to pass, if any.
        //
        //   transaction:
        //     The transaction to use, if any.
        //
        //   commandTimeout:
        //     The command timeout (in seconds).
        //
        //   commandType:
        //     The type of command to execute.
        //
        // Remarks:
        //     Note: the row can be accessed via "dynamic", or by casting to an IDictionary<string,object>
        dynamic QueryFirst(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Execute a single-row query asynchronously using Task.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   command:
        //     The command used to query on connection.
        //
        // Remarks:
        //     Note: the row can be accessed via "dynamic", or by casting to an IDictionary<string,object>
        Task<dynamic> QueryFirstAsync(IDbConnection cnn, CommandDefinition command);
        //
        // Summary:
        //     Execute a single-row query asynchronously using Task.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   command:
        //     The command used to query on connection.
        //
        // Type parameters:
        //   T:
        //     The type to return.
        Task<T> QueryFirstAsync<T>(IDbConnection cnn, CommandDefinition command);
        //
        // Summary:
        //     Execute a single-row query asynchronously using Task.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   sql:
        //     The SQL to execute for the query.
        //
        //   param:
        //     The parameters to pass, if any.
        //
        //   transaction:
        //     The transaction to use, if any.
        //
        //   commandTimeout:
        //     The command timeout (in seconds).
        //
        //   commandType:
        //     The type of command to execute.
        Task<dynamic> QueryFirstAsync(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Execute a single-row query asynchronously using Task.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   type:
        //     The type to return.
        //
        //   command:
        //     The command used to query on connection.
        Task<object> QueryFirstAsync(IDbConnection cnn, Type type, CommandDefinition command);
        //
        // Summary:
        //     Execute a single-row query asynchronously using Task.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   sql:
        //     The SQL to execute for the query.
        //
        //   param:
        //     The parameters to pass, if any.
        //
        //   transaction:
        //     The transaction to use, if any.
        //
        //   commandTimeout:
        //     The command timeout (in seconds).
        //
        //   commandType:
        //     The type of command to execute.
        //
        // Type parameters:
        //   T:
        //     The type of result to return.
        Task<T> QueryFirstAsync<T>(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Execute a single-row query asynchronously using Task.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   type:
        //     The type to return.
        //
        //   sql:
        //     The SQL to execute for the query.
        //
        //   param:
        //     The parameters to pass, if any.
        //
        //   transaction:
        //     The transaction to use, if any.
        //
        //   commandTimeout:
        //     The command timeout (in seconds).
        //
        //   commandType:
        //     The type of command to execute.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     type is null.
        Task<object> QueryFirstAsync(IDbConnection cnn, Type type, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Executes a single-row query, returning the data typed as T.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   sql:
        //     The SQL to execute for the query.
        //
        //   param:
        //     The parameters to pass, if any.
        //
        //   transaction:
        //     The transaction to use, if any.
        //
        //   commandTimeout:
        //     The command timeout (in seconds).
        //
        //   commandType:
        //     The type of command to execute.
        //
        // Type parameters:
        //   T:
        //     The type of result to return.
        //
        // Returns:
        //     A sequence of data of the supplied type; if a basic type (int, string, etc) is
        //     queried then the data from the first column in assumed, otherwise an instance
        //     is created per row, and a direct column-name===member-name mapping is assumed
        //     (case insensitive).
        T QueryFirstOrDefault<T>(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Executes a query, returning the data typed as T.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   command:
        //     The command used to query on connection.
        //
        // Type parameters:
        //   T:
        //     The type of results to return.
        //
        // Returns:
        //     A single or null instance of the supplied type; if a basic type (int, string,
        //     etc) is queried then the data from the first column in assumed, otherwise an
        //     instance is created per row, and a direct column-name===member-name mapping is
        //     assumed (case insensitive).
        T QueryFirstOrDefault<T>(IDbConnection cnn, CommandDefinition command);
        //
        // Summary:
        //     Return a dynamic object with properties matching the columns.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   sql:
        //     The SQL to execute for the query.
        //
        //   param:
        //     The parameters to pass, if any.
        //
        //   transaction:
        //     The transaction to use, if any.
        //
        //   commandTimeout:
        //     The command timeout (in seconds).
        //
        //   commandType:
        //     The type of command to execute.
        //
        // Remarks:
        //     Note: the row can be accessed via "dynamic", or by casting to an IDictionary<string,object>
        dynamic QueryFirstOrDefault(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Executes a single-row query, returning the data typed as type.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   type:
        //     The type to return.
        //
        //   sql:
        //     The SQL to execute for the query.
        //
        //   param:
        //     The parameters to pass, if any.
        //
        //   transaction:
        //     The transaction to use, if any.
        //
        //   commandTimeout:
        //     The command timeout (in seconds).
        //
        //   commandType:
        //     The type of command to execute.
        //
        // Returns:
        //     A sequence of data of the supplied type; if a basic type (int, string, etc) is
        //     queried then the data from the first column in assumed, otherwise an instance
        //     is created per row, and a direct column-name===member-name mapping is assumed
        //     (case insensitive).
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     type is null.
        object QueryFirstOrDefault(IDbConnection cnn, Type type, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Execute a single-row query asynchronously using Task.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   command:
        //     The command used to query on connection.
        //
        // Remarks:
        //     Note: the row can be accessed via "dynamic", or by casting to an IDictionary<string,object>
        Task<dynamic> QueryFirstOrDefaultAsync(IDbConnection cnn, CommandDefinition command);
        //
        // Summary:
        //     Execute a single-row query asynchronously using Task.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   sql:
        //     The SQL to execute for the query.
        //
        //   param:
        //     The parameters to pass, if any.
        //
        //   transaction:
        //     The transaction to use, if any.
        //
        //   commandTimeout:
        //     The command timeout (in seconds).
        //
        //   commandType:
        //     The type of command to execute.
        Task<dynamic> QueryFirstOrDefaultAsync(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Execute a single-row query asynchronously using Task.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   sql:
        //     The SQL to execute for the query.
        //
        //   param:
        //     The parameters to pass, if any.
        //
        //   transaction:
        //     The transaction to use, if any.
        //
        //   commandTimeout:
        //     The command timeout (in seconds).
        //
        //   commandType:
        //     The type of command to execute.
        //
        // Type parameters:
        //   T:
        //     The type of result to return.
        Task<T> QueryFirstOrDefaultAsync<T>(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Execute a single-row query asynchronously using Task.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   type:
        //     The type to return.
        //
        //   sql:
        //     The SQL to execute for the query.
        //
        //   param:
        //     The parameters to pass, if any.
        //
        //   transaction:
        //     The transaction to use, if any.
        //
        //   commandTimeout:
        //     The command timeout (in seconds).
        //
        //   commandType:
        //     The type of command to execute.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     type is null.
        Task<object> QueryFirstOrDefaultAsync(IDbConnection cnn, Type type, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Execute a single-row query asynchronously using Task.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   command:
        //     The command used to query on connection.
        //
        // Type parameters:
        //   T:
        //     The type to return.
        Task<T> QueryFirstOrDefaultAsync<T>(IDbConnection cnn, CommandDefinition command);
        //
        // Summary:
        //     Execute a single-row query asynchronously using Task.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   type:
        //     The type to return.
        //
        //   command:
        //     The command used to query on connection.
        Task<object> QueryFirstOrDefaultAsync(IDbConnection cnn, Type type, CommandDefinition command);
        //
        // Summary:
        //     Execute a command that returns multiple result sets, and access each in turn.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   sql:
        //     The SQL to execute for query.
        //
        //   param:
        //     The parameters to use for query.
        //
        //   transaction:
        //     The transaction to use for query.
        //
        //   commandTimeout:
        //     Number of seconds before command execution timeout.
        //
        //   commandType:
        //     Is it a stored proc or a batch?
        SqlMapper.GridReader QueryMultiple(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Execute a command that returns multiple result sets, and access each in turn.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   command:
        //     The command to execute for query.
        SqlMapper.GridReader QueryMultiple(IDbConnection cnn, CommandDefinition command);
        //
        // Summary:
        //     Execute a command that returns multiple result sets, and access each in turn.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   command:
        //     The command to execute for query.
        Task<SqlMapper.GridReader> QueryMultipleAsync(IDbConnection cnn, CommandDefinition command);
        //
        // Summary:
        //     Execute a command that returns multiple result sets, and access each in turn.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   sql:
        //     The SQL to execute for query.
        //
        //   param:
        //     The parameters to use for query.
        //
        //   transaction:
        //     The transaction to use for query.
        //
        //   commandTimeout:
        //     Number of seconds before command execution timeout.
        //
        //   commandType:
        //     Is it a stored proc or a batch?
        Task<SqlMapper.GridReader> QueryMultipleAsync(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Executes a single-row query, returning the data typed as type.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   type:
        //     The type to return.
        //
        //   sql:
        //     The SQL to execute for the query.
        //
        //   param:
        //     The parameters to pass, if any.
        //
        //   transaction:
        //     The transaction to use, if any.
        //
        //   commandTimeout:
        //     The command timeout (in seconds).
        //
        //   commandType:
        //     The type of command to execute.
        //
        // Returns:
        //     A sequence of data of the supplied type; if a basic type (int, string, etc) is
        //     queried then the data from the first column in assumed, otherwise an instance
        //     is created per row, and a direct column-name===member-name mapping is assumed
        //     (case insensitive).
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     type is null.
        object QuerySingle(IDbConnection cnn, Type type, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Executes a query, returning the data typed as T.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   command:
        //     The command used to query on connection.
        //
        // Type parameters:
        //   T:
        //     The type of results to return.
        //
        // Returns:
        //     A single instance of the supplied type; if a basic type (int, string, etc) is
        //     queried then the data from the first column in assumed, otherwise an instance
        //     is created per row, and a direct column-name===member-name mapping is assumed
        //     (case insensitive).
        T QuerySingle<T>(IDbConnection cnn, CommandDefinition command);
        //
        // Summary:
        //     Executes a single-row query, returning the data typed as T.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   sql:
        //     The SQL to execute for the query.
        //
        //   param:
        //     The parameters to pass, if any.
        //
        //   transaction:
        //     The transaction to use, if any.
        //
        //   commandTimeout:
        //     The command timeout (in seconds).
        //
        //   commandType:
        //     The type of command to execute.
        //
        // Type parameters:
        //   T:
        //     The type of result to return.
        //
        // Returns:
        //     A sequence of data of the supplied type; if a basic type (int, string, etc) is
        //     queried then the data from the first column in assumed, otherwise an instance
        //     is created per row, and a direct column-name===member-name mapping is assumed
        //     (case insensitive).
        T QuerySingle<T>(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Return a dynamic object with properties matching the columns.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   sql:
        //     The SQL to execute for the query.
        //
        //   param:
        //     The parameters to pass, if any.
        //
        //   transaction:
        //     The transaction to use, if any.
        //
        //   commandTimeout:
        //     The command timeout (in seconds).
        //
        //   commandType:
        //     The type of command to execute.
        //
        // Remarks:
        //     Note: the row can be accessed via "dynamic", or by casting to an IDictionary<string,object>
        dynamic QuerySingle(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Execute a single-row query asynchronously using Task.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   sql:
        //     The SQL to execute for the query.
        //
        //   param:
        //     The parameters to pass, if any.
        //
        //   transaction:
        //     The transaction to use, if any.
        //
        //   commandTimeout:
        //     The command timeout (in seconds).
        //
        //   commandType:
        //     The type of command to execute.
        Task<dynamic> QuerySingleAsync(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Execute a single-row query asynchronously using Task.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   type:
        //     The type to return.
        //
        //   sql:
        //     The SQL to execute for the query.
        //
        //   param:
        //     The parameters to pass, if any.
        //
        //   transaction:
        //     The transaction to use, if any.
        //
        //   commandTimeout:
        //     The command timeout (in seconds).
        //
        //   commandType:
        //     The type of command to execute.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     type is null.
        Task<object> QuerySingleAsync(IDbConnection cnn, Type type, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Execute a single-row query asynchronously using Task.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   sql:
        //     The SQL to execute for the query.
        //
        //   param:
        //     The parameters to pass, if any.
        //
        //   transaction:
        //     The transaction to use, if any.
        //
        //   commandTimeout:
        //     The command timeout (in seconds).
        //
        //   commandType:
        //     The type of command to execute.
        //
        // Type parameters:
        //   T:
        //     The type of result to return.
        Task<T> QuerySingleAsync<T>(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Execute a single-row query asynchronously using Task.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   type:
        //     The type to return.
        //
        //   command:
        //     The command used to query on connection.
        Task<object> QuerySingleAsync(IDbConnection cnn, Type type, CommandDefinition command);
        //
        // Summary:
        //     Execute a single-row query asynchronously using Task.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   command:
        //     The command used to query on connection.
        //
        // Type parameters:
        //   T:
        //     The type to return.
        Task<T> QuerySingleAsync<T>(IDbConnection cnn, CommandDefinition command);
        //
        // Summary:
        //     Execute a single-row query asynchronously using Task.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   command:
        //     The command used to query on connection.
        //
        // Remarks:
        //     Note: the row can be accessed via "dynamic", or by casting to an IDictionary<string,object>
        Task<dynamic> QuerySingleAsync(IDbConnection cnn, CommandDefinition command);
        //
        // Summary:
        //     Return a dynamic object with properties matching the columns.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   sql:
        //     The SQL to execute for the query.
        //
        //   param:
        //     The parameters to pass, if any.
        //
        //   transaction:
        //     The transaction to use, if any.
        //
        //   commandTimeout:
        //     The command timeout (in seconds).
        //
        //   commandType:
        //     The type of command to execute.
        //
        // Remarks:
        //     Note: the row can be accessed via "dynamic", or by casting to an IDictionary<string,object>
        dynamic QuerySingleOrDefault(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Executes a query, returning the data typed as T.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   command:
        //     The command used to query on connection.
        //
        // Type parameters:
        //   T:
        //     The type of results to return.
        //
        // Returns:
        //     A single instance of the supplied type; if a basic type (int, string, etc) is
        //     queried then the data from the first column in assumed, otherwise an instance
        //     is created per row, and a direct column-name===member-name mapping is assumed
        //     (case insensitive).
        T QuerySingleOrDefault<T>(IDbConnection cnn, CommandDefinition command);
        //
        // Summary:
        //     Executes a single-row query, returning the data typed as T.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   sql:
        //     The SQL to execute for the query.
        //
        //   param:
        //     The parameters to pass, if any.
        //
        //   transaction:
        //     The transaction to use, if any.
        //
        //   commandTimeout:
        //     The command timeout (in seconds).
        //
        //   commandType:
        //     The type of command to execute.
        //
        // Type parameters:
        //   T:
        //     The type of result to return.
        //
        // Returns:
        //     A sequence of data of the supplied type; if a basic type (int, string, etc) is
        //     queried then the data from the first column in assumed, otherwise an instance
        //     is created per row, and a direct column-name===member-name mapping is assumed
        //     (case insensitive).
        T QuerySingleOrDefault<T>(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Executes a single-row query, returning the data typed as type.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   type:
        //     The type to return.
        //
        //   sql:
        //     The SQL to execute for the query.
        //
        //   param:
        //     The parameters to pass, if any.
        //
        //   transaction:
        //     The transaction to use, if any.
        //
        //   commandTimeout:
        //     The command timeout (in seconds).
        //
        //   commandType:
        //     The type of command to execute.
        //
        // Returns:
        //     A sequence of data of the supplied type; if a basic type (int, string, etc) is
        //     queried then the data from the first column in assumed, otherwise an instance
        //     is created per row, and a direct column-name===member-name mapping is assumed
        //     (case insensitive).
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     type is null.
        object QuerySingleOrDefault(IDbConnection cnn, Type type, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Execute a single-row query asynchronously using Task.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   type:
        //     The type to return.
        //
        //   sql:
        //     The SQL to execute for the query.
        //
        //   param:
        //     The parameters to pass, if any.
        //
        //   transaction:
        //     The transaction to use, if any.
        //
        //   commandTimeout:
        //     The command timeout (in seconds).
        //
        //   commandType:
        //     The type of command to execute.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     type is null.
        Task<object> QuerySingleOrDefaultAsync(IDbConnection cnn, Type type, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Execute a single-row query asynchronously using Task.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   type:
        //     The type to return.
        //
        //   command:
        //     The command used to query on connection.
        Task<object> QuerySingleOrDefaultAsync(IDbConnection cnn, Type type, CommandDefinition command);
        //
        // Summary:
        //     Execute a single-row query asynchronously using Task.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   sql:
        //     The SQL to execute for the query.
        //
        //   param:
        //     The parameters to pass, if any.
        //
        //   transaction:
        //     The transaction to use, if any.
        //
        //   commandTimeout:
        //     The command timeout (in seconds).
        //
        //   commandType:
        //     The type of command to execute.
        Task<dynamic> QuerySingleOrDefaultAsync(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Execute a single-row query asynchronously using Task.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   sql:
        //     The SQL to execute for the query.
        //
        //   param:
        //     The parameters to pass, if any.
        //
        //   transaction:
        //     The transaction to use, if any.
        //
        //   commandTimeout:
        //     The command timeout (in seconds).
        //
        //   commandType:
        //     The type of command to execute.
        //
        // Type parameters:
        //   T:
        //     The type to return.
        Task<T> QuerySingleOrDefaultAsync<T>(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null);
        //
        // Summary:
        //     Execute a single-row query asynchronously using Task.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   command:
        //     The command used to query on connection.
        //
        // Remarks:
        //     Note: the row can be accessed via "dynamic", or by casting to an IDictionary<string,object>
        Task<dynamic> QuerySingleOrDefaultAsync(IDbConnection cnn, CommandDefinition command);
        //
        // Summary:
        //     Execute a single-row query asynchronously using Task.
        //
        // Parameters:
        //   cnn:
        //     The connection to query on.
        //
        //   command:
        //     The command used to query on connection.
        //
        // Type parameters:
        //   T:
        //     The type to return.
        Task<T> QuerySingleOrDefaultAsync<T>(IDbConnection cnn, CommandDefinition command);
        //
        // Summary:
        //     Replace all literal tokens with their text form.
        //
        // Parameters:
        //   parameters:
        //     The parameter lookup to do replacements with.
        //
        //   command:
        //     The command to replace parameters in.
        void ReplaceLiterals(SqlMapper.IParameterLookup parameters, IDbCommand command);
        //
        // Summary:
        //     Associate a DataTable with a type name.
        //
        // Parameters:
        //   table:
        //     The System.Data.DataTable that does with the typeName.
        //
        //   typeName:
        //     The name of the type this table is for.
        void SetTypeName(DataTable table, string typeName);
    }
}
