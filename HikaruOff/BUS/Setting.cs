using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HikaruOff.BUS
{
    class Setting
    {
        //Khởi tạo các biến giá trị.
        string _settingLogo, _settingLanguage, _settingIcon;

        //Khởi tạo mặc định của class.
        public Setting() { }

        public string SettingIcon { get => _settingIcon; set => _settingIcon = value; }
        public string SettingLanguage { get => _settingLanguage; set => _settingLanguage = value; }
        public string SettingLogo { get => _settingLogo; set => _settingLogo = value; }
    }
}
