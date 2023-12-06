using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SzttCegreszlegekHf
{
    abstract class ObservableSubject<Observer, Message>
    {
        protected List<Observer> observers = new List<Observer>();

        protected abstract void Notify(Message msg);

        public virtual void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public virtual bool Detach(Observer observer)
        {
            return observers.Remove(observer);
        }
    }
}
