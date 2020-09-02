using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TABLE_MAKE_MAN.Models
{
    public class ColumnInfoModel
    {
        //列名
        [Display(Name = "カラム名")]
        [Required(ErrorMessage = "列名は必須入力です。")]
        public string ColumnName { get; set; }

        //型選択
        [Display(Name = "データ型選択")]
        public string ChoiceType { get; set; }

        //最大桁数
        [Display(Name = "最大桁数")]
        public int MaxKeta { get; set; }

        //デフォルト値
        [Display(Name = "デフォルト値")]
        public string DefaultValue { get; set; }

        //主キー設定
        [Display(Name = "キーに設定")]
        public bool Keyflg { get; set; }

        //NULL許諾の有無
        [Display(Name = "NULLを許可")]
        public bool Nullflg { get; set; }
    }
}