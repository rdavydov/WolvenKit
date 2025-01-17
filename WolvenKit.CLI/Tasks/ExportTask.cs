using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using CP77.CR2W;
using WolvenKit.Common.DDS;
using WolvenKit.Common.Services;

namespace CP77Tools.Tasks
{
    public static partial class ConsoleFunctions
    {
        #region Methods

        public static void ExportTask(string[] path, EUncookExtension uncookext, bool flip)
        {
            if (path == null || path.Length < 1)
            {
                logger.LogString("Please fill in an input path.", Logtype.Error);
                return;
            }

            Parallel.ForEach(path, file =>
            {
                ExportTaskInner(file, uncookext, flip);
            });
        }

        private static int ExportTaskInner(string path, EUncookExtension uncookext, bool flip)
        {
            #region checks

            if (string.IsNullOrEmpty(path))
            {
                logger.LogString("Please fill in an input path.", Logtype.Error);
                return 0;
            }
            var inputFileInfo = new FileInfo(path);
            if (!inputFileInfo.Exists)
            {
                logger.LogString("Input file does not exist.", Logtype.Error);
                return 0;
            }

            #endregion checks

            Stopwatch watch = new();
            watch.Restart();

            if (ModTools.Export(new FileInfo(path), uncookext, flip))

            {
                watch.Stop();
                logger.LogString($"Successfully exported {path} in {watch.ElapsedMilliseconds.ToString()}ms.", Logtype.Success);
            }
            else
            {
                watch.Stop();
                logger.LogString($"Failed to export {path}.", Logtype.Error);
            }

            return 1;
        }

        #endregion Methods
    }
}
