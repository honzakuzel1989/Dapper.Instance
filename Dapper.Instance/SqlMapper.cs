﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;

namespace Dapper.Instance
{
    public class SqlMapper : ISqlMapper
    {
        public Dapper.SqlMapper.ICustomQueryParameter AsTableValuedParameter<T>(IEnumerable<T> list, string typeName = null) where T : IDataRecord
        {
            return Dapper.SqlMapper.AsTableValuedParameter<T>(list, typeName);
        }

        public Dapper.SqlMapper.ICustomQueryParameter AsTableValuedParameter(DataTable table, string typeName = null)
        {
            return Dapper.SqlMapper.AsTableValuedParameter(table, typeName);
        }

        public int Execute(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.Execute(cnn, sql, param, transaction, commandTimeout, commandType);
        }

        public int Execute(IDbConnection cnn, CommandDefinition command)
        {
            return Dapper.SqlMapper.Execute(cnn, command);
        }

        public Task<int> ExecuteAsync(IDbConnection cnn, CommandDefinition command)
        {
            return Dapper.SqlMapper.ExecuteAsync(cnn, command);
        }

        public Task<int> ExecuteAsync(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.ExecuteAsync(cnn, sql, param, transaction, commandTimeout, commandType);
        }

        public IDataReader ExecuteReader(IDbConnection cnn, CommandDefinition command, CommandBehavior commandBehavior)
        {
            return Dapper.SqlMapper.ExecuteReader(cnn, command, commandBehavior);
        }

        public IDataReader ExecuteReader(IDbConnection cnn, CommandDefinition command)
        {
            return Dapper.SqlMapper.ExecuteReader(cnn, command);
        }

        public IDataReader ExecuteReader(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.ExecuteReader(cnn, sql, param, transaction, commandTimeout, commandType);
        }

        public Task<IDataReader> ExecuteReaderAsync(IDbConnection cnn, CommandDefinition command, CommandBehavior commandBehavior)
        {
            return Dapper.SqlMapper.ExecuteReaderAsync(cnn, command, commandBehavior);
        }

        public Task<DbDataReader> ExecuteReaderAsync(DbConnection cnn, CommandDefinition command)
        {
            return Dapper.SqlMapper.ExecuteReaderAsync(cnn, command);
        }

        public Task<IDataReader> ExecuteReaderAsync(IDbConnection cnn, CommandDefinition command)
        {
            return Dapper.SqlMapper.ExecuteReaderAsync(cnn, command);
        }

        public Task<DbDataReader> ExecuteReaderAsync(DbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.ExecuteReaderAsync(cnn, sql, param, transaction, commandTimeout, commandType);
        }

        public Task<IDataReader> ExecuteReaderAsync(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.ExecuteReaderAsync(cnn, sql, param, transaction, commandTimeout, commandType);
        }

        public Task<DbDataReader> ExecuteReaderAsync(DbConnection cnn, CommandDefinition command, CommandBehavior commandBehavior)
        {
            return Dapper.SqlMapper.ExecuteReaderAsync(cnn, command, commandBehavior);
        }

        public object ExecuteScalar(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.ExecuteScalar(cnn, sql, param, transaction, commandTimeout, commandType);
        }

        public T ExecuteScalar<T>(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.ExecuteScalar<T>(cnn, sql, param, transaction, commandTimeout, commandType);
        }

        public T ExecuteScalar<T>(IDbConnection cnn, CommandDefinition command)
        {
            return Dapper.SqlMapper.ExecuteScalar<T>(cnn, command);
        }

        public object ExecuteScalar(IDbConnection cnn, CommandDefinition command)
        {
            return Dapper.SqlMapper.ExecuteScalar(cnn, command);
        }

        public Task<object> ExecuteScalarAsync(IDbConnection cnn, CommandDefinition command)
        {
            return Dapper.SqlMapper.ExecuteScalarAsync(cnn, command);
        }

        public Task<T> ExecuteScalarAsync<T>(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.ExecuteScalarAsync<T>(cnn, sql, param, transaction, commandTimeout, commandType);
        }

        public Task<object> ExecuteScalarAsync(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.ExecuteScalarAsync(cnn, sql, param, transaction, commandTimeout, commandType);
        }

        public Task<T> ExecuteScalarAsync<T>(IDbConnection cnn, CommandDefinition command)
        {
            return Dapper.SqlMapper.ExecuteScalarAsync<T>(cnn, command);
        }

        public Func<IDataReader, T> GetRowParser<T>(IDataReader reader, Type concreteType = null, int startIndex = 0, int length = -1, bool returnNullIfFirstMissing = false)
        {
            return Dapper.SqlMapper.GetRowParser<T>(reader, concreteType, startIndex, length, returnNullIfFirstMissing);
        }

        public Func<IDataReader, object> GetRowParser(IDataReader reader, Type type, int startIndex = 0, int length = -1, bool returnNullIfFirstMissing = false)
        {
            return Dapper.SqlMapper.GetRowParser(reader, type, startIndex, length, returnNullIfFirstMissing);
        }

        public IEnumerable<object> Parse(IDataReader reader, Type type)
        {
            return Dapper.SqlMapper.Parse(reader, type);
        }

        public IEnumerable<T> Parse<T>(IDataReader reader)
        {
            return Dapper.SqlMapper.Parse<T>(reader);
        }

        public IEnumerable<dynamic> Parse(IDataReader reader)
        {
            return Dapper.SqlMapper.Parse(reader);
        }

        public IEnumerable<object> Query(IDbConnection cnn, Type type, string sql, object param = null, IDbTransaction transaction = null, bool buffered = true, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.Query(cnn, type, sql, param, transaction, buffered, commandTimeout, commandType);
        }

        public IEnumerable<T> Query<T>(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, bool buffered = true, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.Query<T>(cnn, sql, param, transaction, buffered, commandTimeout, commandType);
        }

        public IEnumerable<TReturn> Query<TReturn>(IDbConnection cnn, string sql, Type[] types, Func<object[], TReturn> map, object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.Query<TReturn>(cnn, sql, types, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn>(IDbConnection cnn, string sql, Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn> map, object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.Query<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn>(cnn, sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(IDbConnection cnn, string sql, Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn> map, object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.Query<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(cnn, sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public IEnumerable<TReturn> Query<TFirst, TSecond, TReturn>(IDbConnection cnn, string sql, Func<TFirst, TSecond, TReturn> map, object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.Query<TFirst, TSecond, TReturn>(cnn, sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(IDbConnection cnn, string sql, Func<TFirst, TSecond, TThird, TFourth, TFifth, TReturn> map, object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.Query<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(cnn, sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TReturn>(IDbConnection cnn, string sql, Func<TFirst, TSecond, TThird, TFourth, TReturn> map, object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.Query<TFirst, TSecond, TThird, TFourth, TReturn>(cnn, sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public IEnumerable<dynamic> Query(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, bool buffered = true, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.Query(cnn, sql, param, transaction, buffered, commandTimeout, commandType);
        }

        public IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TReturn>(IDbConnection cnn, string sql, Func<TFirst, TSecond, TThird, TReturn> map, object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.Query<TFirst, TSecond, TThird, TReturn>(cnn, sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public IEnumerable<T> Query<T>(IDbConnection cnn, CommandDefinition command)
        {
            return Dapper.SqlMapper.Query<T>(cnn, command);
        }

        public Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TReturn>(IDbConnection cnn, CommandDefinition command, Func<TFirst, TSecond, TReturn> map, string splitOn = "Id")
        {
            return Dapper.SqlMapper.QueryAsync<TFirst, TSecond, TReturn>(cnn, command, map, splitOn);
        }

        public Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TReturn>(IDbConnection cnn, string sql, Func<TFirst, TSecond, TReturn> map, object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.QueryAsync<TFirst, TSecond, TReturn>(cnn, sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public Task<IEnumerable<dynamic>> QueryAsync(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.QueryAsync(cnn, sql, param, transaction, commandTimeout, commandType);
        }

        public Task<IEnumerable<dynamic>> QueryAsync(IDbConnection cnn, CommandDefinition command)
        {
            return Dapper.SqlMapper.QueryAsync(cnn, command);
        }

        public Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TReturn>(IDbConnection cnn, string sql, Func<TFirst, TSecond, TThird, TReturn> map, object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.QueryAsync<TFirst, TSecond, TThird, TReturn>(cnn, sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TReturn>(IDbConnection cnn, CommandDefinition command, Func<TFirst, TSecond, TThird, TReturn> map, string splitOn = "Id")
        {
            return Dapper.SqlMapper.QueryAsync<TFirst, TSecond, TThird, TReturn>(cnn, command, map, splitOn);
        }

        public Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TReturn>(IDbConnection cnn, string sql, Func<TFirst, TSecond, TThird, TFourth, TReturn> map, object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.QueryAsync<TFirst, TSecond, TThird, TFourth, TReturn>(cnn, sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TReturn>(IDbConnection cnn, CommandDefinition command, Func<TFirst, TSecond, TThird, TFourth, TReturn> map, string splitOn = "Id")
        {
            return Dapper.SqlMapper.QueryAsync<TFirst, TSecond, TThird, TFourth, TReturn>(cnn, command, map, splitOn);
        }

        public Task<IEnumerable<object>> QueryAsync(IDbConnection cnn, Type type, CommandDefinition command)
        {
            return Dapper.SqlMapper.QueryAsync(cnn, type, command);
        }

        public Task<IEnumerable<T>> QueryAsync<T>(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.QueryAsync<T>(cnn, sql, param, transaction, commandTimeout, commandType);
        }

        public Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(IDbConnection cnn, string sql, Func<TFirst, TSecond, TThird, TFourth, TFifth, TReturn> map, object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(cnn, sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(IDbConnection cnn, string sql, Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn> map, object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(cnn, sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(IDbConnection cnn, CommandDefinition command, Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn> map, string splitOn = "Id")
        {
            return Dapper.SqlMapper.QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(cnn, command, map, splitOn);
        }

        public Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn>(IDbConnection cnn, string sql, Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn> map, object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn>(cnn, sql, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn>(IDbConnection cnn, CommandDefinition command, Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn> map, string splitOn = "Id")
        {
            return Dapper.SqlMapper.QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn>(cnn, command, map, splitOn);
        }

        public Task<IEnumerable<TReturn>> QueryAsync<TReturn>(IDbConnection cnn, string sql, Type[] types, Func<object[], TReturn> map, object param = null, IDbTransaction transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.QueryAsync<TReturn>(cnn, sql, types, map, param, transaction, buffered, splitOn, commandTimeout, commandType);
        }

        public Task<IEnumerable<object>> QueryAsync(IDbConnection cnn, Type type, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.QueryAsync(cnn, type, sql, param, transaction, commandTimeout, commandType);
        }

        public Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(IDbConnection cnn, CommandDefinition command, Func<TFirst, TSecond, TThird, TFourth, TFifth, TReturn> map, string splitOn = "Id")
        {
            return Dapper.SqlMapper.QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(cnn, command, map, splitOn);
        }

        public Task<IEnumerable<T>> QueryAsync<T>(IDbConnection cnn, CommandDefinition command)
        {
            return Dapper.SqlMapper.QueryAsync<T>(cnn, command);
        }

        public T QueryFirst<T>(IDbConnection cnn, CommandDefinition command)
        {
            return Dapper.SqlMapper.QueryFirst<T>(cnn, command);
        }

        public object QueryFirst(IDbConnection cnn, Type type, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.QueryFirst(cnn, type, sql, param, transaction, commandTimeout, commandType);
        }

        public T QueryFirst<T>(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.QueryFirst<T>(cnn, sql, param, transaction, commandTimeout, commandType);
        }

        public dynamic QueryFirst(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.QueryFirst(cnn, sql, param, transaction, commandTimeout, commandType);
        }

        public Task<dynamic> QueryFirstAsync(IDbConnection cnn, CommandDefinition command)
        {
            return Dapper.SqlMapper.QueryFirstAsync(cnn, command);
        }

        public Task<T> QueryFirstAsync<T>(IDbConnection cnn, CommandDefinition command)
        {
            return Dapper.SqlMapper.QueryFirstAsync<T>(cnn, command);
        }

        public Task<dynamic> QueryFirstAsync(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.QueryFirstAsync(cnn, sql, param, transaction, commandTimeout, commandType);
        }

        public Task<object> QueryFirstAsync(IDbConnection cnn, Type type, CommandDefinition command)
        {
            return Dapper.SqlMapper.QueryFirstAsync(cnn, type, command);
        }

        public Task<T> QueryFirstAsync<T>(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.QueryFirstAsync<T>(cnn, sql, param, transaction, commandTimeout, commandType);
        }

        public Task<object> QueryFirstAsync(IDbConnection cnn, Type type, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.QueryFirstAsync(cnn, type, sql, param, transaction, commandTimeout, commandType);
        }

        public T QueryFirstOrDefault<T>(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.QueryFirstOrDefault<T>(cnn, sql, param, transaction, commandTimeout, commandType);
        }

        public T QueryFirstOrDefault<T>(IDbConnection cnn, CommandDefinition command)
        {
            return Dapper.SqlMapper.QueryFirstOrDefault<T>(cnn, command);
        }

        public dynamic QueryFirstOrDefault(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.QueryFirstOrDefault(cnn, sql, param, transaction, commandTimeout, commandType);
        }

        public object QueryFirstOrDefault(IDbConnection cnn, Type type, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.QueryFirstOrDefault(cnn, type, sql, param, transaction, commandTimeout, commandType);
        }

        public Task<dynamic> QueryFirstOrDefaultAsync(IDbConnection cnn, CommandDefinition command)
        {
            return Dapper.SqlMapper.QueryFirstOrDefaultAsync(cnn, command);
        }

        public Task<dynamic> QueryFirstOrDefaultAsync(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.QueryFirstOrDefaultAsync(cnn, sql, param, transaction, commandTimeout, commandType);
        }

        public Task<T> QueryFirstOrDefaultAsync<T>(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.QueryFirstOrDefaultAsync<T>(cnn, sql, param, transaction, commandTimeout, commandType);
        }

        public Task<object> QueryFirstOrDefaultAsync(IDbConnection cnn, Type type, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.QueryFirstOrDefaultAsync(cnn, type, sql, param, transaction, commandTimeout, commandType);
        }

        public Task<T> QueryFirstOrDefaultAsync<T>(IDbConnection cnn, CommandDefinition command)
        {
            return Dapper.SqlMapper.QueryFirstOrDefaultAsync<T>(cnn, command);
        }

        public Task<object> QueryFirstOrDefaultAsync(IDbConnection cnn, Type type, CommandDefinition command)
        {
            return Dapper.SqlMapper.QueryFirstOrDefaultAsync(cnn, type, command);
        }

        public Dapper.SqlMapper.GridReader QueryMultiple(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.QueryMultiple(cnn, sql, param, transaction, commandTimeout, commandType);
        }

        public Dapper.SqlMapper.GridReader QueryMultiple(IDbConnection cnn, CommandDefinition command)
        {
            return Dapper.SqlMapper.QueryMultiple(cnn, command);
        }

        public Task<Dapper.SqlMapper.GridReader> QueryMultipleAsync(IDbConnection cnn, CommandDefinition command)
        {
            return Dapper.SqlMapper.QueryMultipleAsync(cnn, command);
        }

        public Task<Dapper.SqlMapper.GridReader> QueryMultipleAsync(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.QueryMultipleAsync(cnn, sql, param, transaction, commandTimeout, commandType);
        }

        public object QuerySingle(IDbConnection cnn, Type type, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.QuerySingle(cnn, type, sql, param, transaction, commandTimeout, commandType);
        }

        public T QuerySingle<T>(IDbConnection cnn, CommandDefinition command)
        {
            return Dapper.SqlMapper.QuerySingle<T>(cnn, command);
        }

        public T QuerySingle<T>(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.QuerySingle<T>(cnn, sql, param, transaction, commandTimeout, commandType);
        }

        public dynamic QuerySingle(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.QuerySingle(cnn, sql, param, transaction, commandTimeout, commandType);
        }

        public Task<dynamic> QuerySingleAsync(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.QuerySingleAsync(cnn, sql, param, transaction, commandTimeout, commandType);
        }

        public Task<object> QuerySingleAsync(IDbConnection cnn, Type type, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.QuerySingleAsync(cnn, type, sql, param, transaction, commandTimeout, commandType);
        }

        public Task<T> QuerySingleAsync<T>(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.QuerySingleAsync<T>(cnn, sql, param, transaction, commandTimeout, commandType);
        }

        public Task<object> QuerySingleAsync(IDbConnection cnn, Type type, CommandDefinition command)
        {
            return Dapper.SqlMapper.QuerySingleAsync(cnn, type, command);
        }

        public Task<T> QuerySingleAsync<T>(IDbConnection cnn, CommandDefinition command)
        {
            return Dapper.SqlMapper.QuerySingleAsync<T>(cnn, command);
        }

        public Task<dynamic> QuerySingleAsync(IDbConnection cnn, CommandDefinition command)
        {
            return Dapper.SqlMapper.QuerySingleAsync(cnn, command);
        }

        public dynamic QuerySingleOrDefault(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.QuerySingleOrDefault(cnn, sql, param, transaction, commandTimeout, commandType);
        }

        public T QuerySingleOrDefault<T>(IDbConnection cnn, CommandDefinition command)
        {
            return Dapper.SqlMapper.QuerySingleOrDefault<T>(cnn, command);
        }

        public T QuerySingleOrDefault<T>(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.QuerySingleOrDefault<T>(cnn, sql, param, transaction, commandTimeout, commandType);
        }

        public object QuerySingleOrDefault(IDbConnection cnn, Type type, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.QuerySingleOrDefault(cnn, type, sql, param, transaction, commandTimeout, commandType);
        }

        public Task<object> QuerySingleOrDefaultAsync(IDbConnection cnn, Type type, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.QuerySingleOrDefaultAsync(cnn, type, sql, param, transaction, commandTimeout, commandType);
        }

        public Task<object> QuerySingleOrDefaultAsync(IDbConnection cnn, Type type, CommandDefinition command)
        {
            return Dapper.SqlMapper.QuerySingleOrDefaultAsync(cnn, type, command);
        }

        public Task<dynamic> QuerySingleOrDefaultAsync(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.QuerySingleOrDefaultAsync(cnn, sql, param, transaction, commandTimeout, commandType);
        }

        public Task<T> QuerySingleOrDefaultAsync<T>(IDbConnection cnn, string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Dapper.SqlMapper.QuerySingleOrDefaultAsync<T>(cnn, sql, param, transaction, commandTimeout, commandType);
        }

        public Task<dynamic> QuerySingleOrDefaultAsync(IDbConnection cnn, CommandDefinition command)
        {
            return Dapper.SqlMapper.QuerySingleOrDefaultAsync(cnn, command);
        }

        public Task<T> QuerySingleOrDefaultAsync<T>(IDbConnection cnn, CommandDefinition command)
        {
            return Dapper.SqlMapper.QuerySingleOrDefaultAsync<T>(cnn, command);
        }
    }
}
