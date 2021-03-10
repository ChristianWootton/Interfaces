using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces{
    class DbMigrator{
        private readonly ILogger _logger;
        
        public DbMigrator(ILogger logger){
            _logger = logger;
        }

        public void Migrate(){
            _logger.LogInfo("Migrating started @ {0}" +  DateTime.Now);
            _logger.LogInfo("Migrating ended @ {0}" + DateTime.Now);
        }
    }
}
