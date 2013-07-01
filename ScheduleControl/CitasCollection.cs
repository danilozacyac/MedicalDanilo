using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleControl
{
    public class CitasCollection : ObservableCollection<Citas>
    {

        public CitasCollection()
        {
            DateTime today = DateTime.Today;

            foreach (Citas t in Enumerable.Range(9, 14).Select(i => new Citas
                                                        {
                                                            Start = today.AddMinutes(i * 60 + 15),
                                                            End = today.AddMinutes((i + 1) * 60),
                                                            Subject = string.Format("Task num. {0}", i),
                                                            IsDone = today.AddMinutes((i + 1) * 60) < DateTime.Now
                                                        }))
            {
                this.Add(t);
            }
        }
    }
}
