namespace Tuan1{

internal class ClassGenrics<T>{

        public T Property1 {get; set;}
        public T Property2 {get; set;}
        public ClassGenrics(T Property1, T Property2){
            this.Property1 = Property1;
            this.Property2 = Property2;
        }
    }

}


