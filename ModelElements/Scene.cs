namespace S1.ModelElements
{
    internal class Scene
    {
        public int Id { get; set; }
        public List<PoligonalModel> Models { get; set; }
        public List<Flash>? Flashes { get; set; }


        public Scene(List<PoligonalModel> poligonalModels, List<Camera> cameras, List<Flash>? flashes = null)
        {
            Models = poligonalModels;
            Flashes = flashes;
            // не понятно что делать с camera, т.к. в диаграмме у сцены нет таких полей и свойств, однако связь нарисована
        }

        public T Method1<T>(T obj) =>
            throw new NotImplementedException();

        public T Method2<T>(T obj1, T obj2) => 
            throw new NotImplementedException();
    }
}