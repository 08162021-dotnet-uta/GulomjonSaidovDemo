using System;
using System.ComponentModel.DataAnnotations;

namespace TargetStore
{
  public class ViewModelCustomer
  {
    private string fname;
    private string lname;

    [StringLength(20, MinimumLength = 1)]
    public string Fname
    {
      get
      {
        return this.fname;
      }
      set
      {
        if (value.Length > 50 || value.Length == 0)
        {
          this.fname = "Invalid name input";
        }
        else
                {
                    this.fname = value;
                }
      }
    }
    public string Lname
        {
            get
            {
                return this.lname;
            }
            set
            {
                if (value.Length > 50 || value.Length == 0)
                {
                    this.lname = "Invalid name input";
                }
                else
                {
                    this.lname = value;
                }
            }
        }

    public ViewModelCustomer() { }

    public ViewModelCustomer(string fname, string lname)
    {
      this.Fname = fname;
      this.Lname = lname;
    }
    
  }
}