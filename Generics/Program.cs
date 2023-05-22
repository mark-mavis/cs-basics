namespace Generics{
    class Datastore<T>{
        public T Data {get; set;}
    }

    class KeyValuePair<TKey, TValue>{
        public TKey Key {get; set;}
        public TValue Value {get; set;}
    }

    class CustomDictionary<KeyValuePairType>{
        public List<KeyValuePairType> keyValuePairs {get; set;}
        public void AddKeyValuePair(KeyValuePairType kp){
            keyValuePairs.Add(kp);
        }
    }
    
    
    
    class Program{
        public static void Main(string[] args){
            Datastore<int> intDataStorage = new Datastore<int>();
            intDataStorage.Data = 10;

            Datastore<string> strDataStorage = new Datastore<string>();
            strDataStorage.Data = "Hello";

            KeyValuePair<string, int> clientAges = new KeyValuePair<string, int>();
            clientAges.Key = "Mark Mavis";
            clientAges.Value = 39;

            KeyValuePair<string, int> markMavis = new KeyValuePair<string, int>(){ Key="Mark Mavis", Value="39"};
            CustomDictionary<KeyValuePair<string, int>> nameList = new CustomDictionary<KeyValuePair<string, int>>();
            nameList.AddKeyValuePair(markMavis);
            
            KeyValuePair<int, int> propertyValue = new KeyValuePair<int, int>(){Key=89576, Value=2000000};
            CustomDictionary<KeyValuePair<int, int>> propertyPurchaseValues = new CustomDictionary<KeyValuePair<int, int>>();
            propertyPurchaseValues.AddKeyValuePair(propertyValue);
            
            


        }
    }
}