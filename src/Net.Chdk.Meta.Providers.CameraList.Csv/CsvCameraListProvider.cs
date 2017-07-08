using Net.Chdk.Meta.Model.CameraList;
using Net.Chdk.Meta.Providers.Csv;
using System.Collections.Generic;
using System.IO;

namespace Net.Chdk.Meta.Providers.CameraList.Csv
{
    sealed class CsvCameraListProvider : CsvCameraProvider<ListPlatformData, ListRevisionData, ListSourceData>, ICameraListProvider
    {
        public IDictionary<string, ListPlatformData> GetCameraList(string path)
        {
            using (var stream = File.OpenRead(path))
            {
                return GetCameras(stream);
            }
        }
    }
}
