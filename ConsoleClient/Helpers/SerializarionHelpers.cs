using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleClient.Models;

namespace ConsoleClient.Helpers
{
    public static class SerializarionHelpers
    {
        public static List<HmdfEntity> GenerateRecords(int count)
        {
            var records = new List<HmdfEntity>();
            for (var i = 0; i < count; i++)
            {
                records.Add(BuiltHmdfTestRecord());
            }
            return records;
        }
        private static HmdfEntity BuiltHmdfTestRecord()
        {
            return new HmdfEntity
            {
                RowId = 1,
                Address = "75 WASHINGTON ST",
                City = "PEABODY",
                STATE_ABRV = "MA",
                Zip = "01960",
                Zip4 = "1563",
                State = "MA",
                MSA = "16974",
                County = "031",
                CensusTrac = "8046.06",
                MmwAddress = "75 WASHINGTON ST",
                mmwCity = "PEABODY",
                mmwState = "MA",
                mmwZip = "01960",
                mmwZip4 = "1563",
                StndStat = "Stnd",
                gsMatchCode = "MC",
                gsLocationCode = "LC",
                gsMatchResult = "MR",
                CongDist = "CD",
                latitude = (decimal)42.012198,
                longitude = (decimal)51.348332,
                BlockGrp = "BG",
                gdtMCD = "MCD",
                gdtPlace = "Gp",
                mmwStat = "B1",
                ULI = "123424",
                LEI = "222312",
                ULIStatus = "1",
                DatasetId = 1,
                Action = "5",
                ApplDate = DateTime.Now,
                ApplDate_NA = false
            };
        }
    }
}
