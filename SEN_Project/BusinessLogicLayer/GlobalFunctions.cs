using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEN_Project.PresentationLayer.Forms.ListSearchForm;

namespace SEN_Project.BusinessLogicLayer
{
    class GlobalFunctions
    {
        public  static  void CopyList<T> (List<T>    Input,List<T>  Output)
        {
            //Output ??= new List<T>();
            Output = Output == null ? new List<T>() : Output;
            foreach (T t in Input)
            {
                Output.Add(t);
            }
        }

        public static frmSearchList CreateSearchForm<T>() where T : ILineable,IDBItem,new()
        {
            frmSearchList SearchForm = Factory.GetSearchList();
            List<T> AllItems = BusinessLogic.current.GetAll<T>();
            List<string> Options = new List<string>();
            foreach (T item in AllItems)
            {
                Options.Add(item.ToLine());
            }
            SearchForm.SetItems(Options);
            return SearchForm;
        }

        public static frmSearchList CreateSearchForm<T>(List<T> AllItems) where T : ILineable, IDBItem
        {
            if (AllItems==null)
            {
                return null;
            }
            frmSearchList SearchForm = Factory.GetSearchList();
            List<string> Options = new List<string>();
            foreach (T item in AllItems)
            {
                Options.Add(item.ToLine());
            }
            SearchForm.SetItems(Options);
            return SearchForm;
        }
    }
}
