using System;

namespace NSpec.Interpreter.Array
{
    public class When
    {
        private readonly Action<string, Action> setter;
        public When(Action<string,Action> setter)
        {
            this.setter = setter;
        }
        private string name;

        public Action this[string indexer]
        {
            get
            {
                //not sure what needs to happen here?
                return new Action(() => { });
            } 
            set
            {
                name = indexer;
                setter(name,value);
            }
        }
    }
    public class ActionRegister 
    {
        private readonly Action<Action> setter;

        public ActionRegister(Action<Action> setter)
        {
            this.setter = setter;
        }

        public Action each
        {
            set { setter(value); }
        }

        //TODO:make it behave differently as expected
        public Action all
        {
            set { setter(value); }
        }
    }
}