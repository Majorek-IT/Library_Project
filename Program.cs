builder.Services.AddDbContext<LibraryContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("LibraryConnection"),
        ServerVersion.AutoDetect(
            builder.Configuration.GetConnectionString("LibraryConnection")
        )
    )
);
