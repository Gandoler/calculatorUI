﻿using Serilog;

namespace OTSCSERVER.Tools.AppSettingsParse.Templaetes
{
    public class ServerSettings : ITemplates
    {
        public string Server { get; set; } = string.Empty;
        public int Port { get; set; }
        public string Database { get; set; } = string.Empty;
        public string User { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public string GetConnectionString()
        {
            if (string.IsNullOrWhiteSpace(Server) ||
                string.IsNullOrWhiteSpace(Database) ||
                string.IsNullOrWhiteSpace(User) ||
                string.IsNullOrWhiteSpace(Password))
            {
                Log.Information("ServerSettings: now in template:" + ToString());
                Log.Error("ServerSettings:One or more required fields are missing for the connection string.");

            }

            return $"Server={Server};Port={Port};Database={Database};User Id={User};Password={Password};";
        }
        public override string ToString()
        {
            return $"{Server?.ToString()}, {Port}, {Database?.ToString()}, {User?.ToString()}, {Password?.ToString()}";
        }
    }
}
