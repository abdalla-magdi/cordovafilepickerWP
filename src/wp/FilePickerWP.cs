using WPCordovaClassLib.Cordova;
using WPCordovaClassLib.Cordova.Commands;
using WPCordovaClassLib.Cordova.JSON;

namespace Cordova.Extension.Commands
{
    /// <summary>
    /// Implementes access to file picker for WP 8.1
    /// http://msdn.microsoft.com/en-US/library/windows/apps/windows.storage.pickers.fileopenpicker.picksinglefileandcontinue
    /// </summary>
	
    public class FilePickerWP : BaseCommand
    {

        public void open(string options)
        {
            string[] options = JsonHelper.Deserialize<string[]>(options);

            DispatchCommandResult();
			//DispatchCommandResult(new PluginResult(PluginResult.Status.OK, true));
        }

    }
}
