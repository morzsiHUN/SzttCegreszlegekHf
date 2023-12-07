namespace SzttCegreszlegekHf
{
    // Ez az absztakt osztály intézi a feliratkázást, leiratkozást, felülírható metódusokkal
    // Előírja a Notify megvalósítását
    // Generikus típusokkal paraméterezhető, hogy mit küldjön a Notify és milyen típusú a feliratkozó
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
