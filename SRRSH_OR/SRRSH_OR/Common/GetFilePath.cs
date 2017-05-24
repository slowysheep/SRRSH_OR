using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRRSH_OR.Common
{
    public class GetFilePath
    {
        /**
         * 2.获取启动了应用程序的可执行文件的路径，不包括可执行文件的名称。
         * */
        public static string GetStartupPath()
        {
            return System.Windows.Forms.Application.StartupPath;
        }
    }
}
