using System.Data.SQLite;

namespace WeightProgram.Data {
    public static class SQLiteConnectionExtension {
        public static void AddTableIfNotExists(this SQLiteConnection connection, string tableName, string tableArgs) {
            // Create the table if it does not exist
            var command = new SQLiteCommand($@"CREATE TABLE IF NOT EXISTS {tableName} ({tableArgs})", connection);
            command.ExecuteNonQuery();
        }
        public static void AddColumnIfNotExists(this SQLiteConnection connection, string tableName, string columnName, string columnType) {
            // Check if the column exists
            var checkColumnCommand = new SQLiteCommand($@"
                PRAGMA table_info({tableName})", connection);

            using(var reader = checkColumnCommand.ExecuteReader()) {
                bool columnExists = false;
                while(reader.Read()) {
                    if(reader["name"].ToString() == columnName) {
                        columnExists = true;
                        break;
                    }
                }

                // If the column does not exist, add it
                if(!columnExists) {
                    var addColumnCommand = new SQLiteCommand($"ALTER TABLE {tableName} ADD COLUMN {columnName} {columnType}", connection);
                    addColumnCommand.ExecuteNonQuery();
                }
            }

        }
    }
}
