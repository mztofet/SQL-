protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    var connectionString =
        "server=localhost;port=3306;database=FourthWallAcademy;user=root;password=SQLR0ck$;";

    optionsBuilder.UseMySql(
        connectionString,
        ServerVersion.AutoDetect(connectionString)
    );
}