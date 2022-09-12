namespace Serializar {
    [Serializable]
    public class ClsSerializar<T> {
        public string Method { get; set; }
        public T Entity { get; set; }

    }

}