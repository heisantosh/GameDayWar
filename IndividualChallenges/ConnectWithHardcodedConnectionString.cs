public void ConnectWithEnvironmentVariableConnectionString()
{
    var connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING");
    if (string.IsNullOrEmpty(connectionString))
    {
        Console.WriteLine("Connection string is not set in environment variables.");
        return;
    }

    Console.WriteLine("Connecting with connection string from environment variable.");
}
