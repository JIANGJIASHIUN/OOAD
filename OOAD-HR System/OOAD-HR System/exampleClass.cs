﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_HR_System
{
    public class ExampleClass //類別宣告首字大寫
    {
        public ExampleClass(int exampleVar1, int exampleVar2); //建構子 function內變數不用底線開頭 逗號後面加空白
        private int _exampleVar; //class宣告的變數需要以底線開頭 當然 元件畫面的label等等都要改

        public void CreateExampleFunction() //function以大寫動詞開頭 Is用在bool的取值 其餘用Get 每個function都要一個換行
        {
            if (_exampleVar == null) //if後面補空白在補括號 運算子前後各補空白
            {
                _exampleVar = 0;
            }
            //while等等同if 
            //for內的變數分號後面補空白
            //最後一個參數後面不補空白 直接補右括號
            //分號前面"不"補空白
        }

        public void CreateExampleFunction2()
        {

        }
    }
}
