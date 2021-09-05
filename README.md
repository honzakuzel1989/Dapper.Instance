# Dapper.Instance
The instance way how to work with Dapper's extension methods. Especially useful for easy mocking and testability.

# Installation

Install `Dapper.Instance` NuGet package to your project

```
Install-Package Dapper.Instance
```

# Usage

Firstly just register `IDapper` interface with `DapperInstance` implementation to your IoC/DI container

```csharp
using Dapper.Instance;

...

services.AddSingleton<IDapper, DapperInstance>();
```

Then inject IDapper interface through constructor to your class where you want to use (or already using) Dapper's method

```csharp
using Dapper.Instance;

...

private readonly IDapper _dapper;

public ClassWithDapperQueries(IDapper dapper)
{
    _dapper = dapper;
}
```

And finally use (or refactor static to) instance methods with connection as parameter

```csharp
public async Task<IEnumerable<TResult>> MethodWithDapperQuery<TResult>(IDbConnection connection, string sql)
{
    // From:
    // return await connection.QueryAsync<TResult>(sql);
    // To:
    return await _dapper.QueryAsync<TResult>(connection, sql);
}
```

# Testing

Now you can easilly test your `ClassWithDapperQueries` because you can mock `IDapper` interface or implement your own for testing with empty methods or whatever

```csharp
using Moq;
using Dapper.Instance;

...

private readonly ClassWithDapperQueries _sat;
private readonly Mock<IDapper> _dapper;
private readonly IDbConnection _connection;

public ClassWithDapperQueriesTests()
{
    _connection = new Mock<IDbConnection>().Object;
    _dapper = new Mock<IDapper>();
    _sat = new ClassWithDapperQueries(_dapper.Object);
}

[Fact()]
public async Task MethodWithDapperQueryTest()
{
    var sql = "SELECT * FROM Users";

    _dapper.Setup(mock => mock.QueryAsync<User>(It.IsAny<IDbConnection>(), It.IsAny<string>(), null, null, null, null))
        .ReturnsAsync(new User[] { });

    var users = await _sat.MethodWithDapperQuery<User>(_connection, sql);

    Assert.Empty(users);

    _dapper.Verify(mock => mock.QueryAsync<User>(_connection, sql, null, null, null, null), 
        Times.Once);
}
```

