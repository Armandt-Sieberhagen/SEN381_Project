using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEN_Project.PresentationLayer.Forms.ListSearchForm;
using SEN_Project.PresentationLayer.Forms;

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

        public static ChangeList CreateChangeList<T>(List<T>  RightItems = null) where T : IDBItem,new()
        {
            ChangeList ChangeForm = Factory.GetChangeForm();
            List<T> LeftItems = BusinessLogic.current.GetAll<T>();
            List<object> Objects = new List<object>();
            foreach (T item in LeftItems)
            {
                Objects.Add(item);
            }
            ChangeForm.SetLeftItems(Objects);
            if (RightItems!=null)
            {
                Objects = new List<object>();
                foreach (T item in RightItems)
                {
                    Objects.Add(item);
                }
                ChangeForm.SetRightItems(Objects);
            }
            return ChangeForm;
        }
    }
}
