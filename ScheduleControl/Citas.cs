using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Windows.Controls.ScheduleView;

namespace ScheduleControl
{
    public class Citas : Appointment
    {
        private bool isDone;
        public bool IsDone
        {
            get
            {
                return this.Storage<Citas>().isDone;
            }
            set
            {
                var storage = this.Storage<Citas>();
                if (storage.isDone != value)
                {
                    storage.isDone = value;
                    this.OnPropertyChanged(() => this.IsDone);
                }
            }
        }

        public override IAppointment Copy()
        {
            var nuevaCita = new Citas();
            nuevaCita.CopyFrom(this);
            return nuevaCita;

        }

        public override void CopyFrom(IAppointment other)
        {
            var cita = other as Citas;
            if (cita != null)
            {

            }

            base.CopyFrom(other);
        }
    }
}
