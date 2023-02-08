using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace MusicAppMVVM.Services.Classes
{
    public static class FileService
    {
        public static async Task WriteToFileAsync(string? id, string fileName)
        {
            var saveDialog = new SaveFileDialog();

            saveDialog.InitialDirectory = @"C:\Users\Wayne\Desktop";
            saveDialog.Filter = "Music Files | .mp3";
            saveDialog.DefaultExt = "mp3";

            saveDialog.FileName = fileName;

            var dialogRes = saveDialog.ShowDialog();

            var res = await ApiService.GetDownloadDataAsync(id);

            await File.WriteAllBytesAsync(Path.GetFullPath(saveDialog.FileName), res);
        }
    }
}
