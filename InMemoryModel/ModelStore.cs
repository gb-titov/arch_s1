using S1.ModelElements;

namespace S1.InMemoryModel
{
    internal class ModelStore : IModelChanger
    {
        public List<PoligonalModel> Models { get; set; }
        public List<Scene> Scenes { get; set; }   
        public List<Flash> Flashes { get; set; }
        public List<Camera> Cameras { get; set; }

        private IModelChangedObserver[]? _changeObservers;

        public ModelStore(IModelChangedObserver[]? observers = null)
        {
            _changeObservers = observers;

            Models = new List<PoligonalModel>();
            Scenes = new List<Scene>();
            Flashes = new List<Flash>();
            Cameras = new List<Camera>();
        }

        public void NotifyChange(IModelChanger sender) =>
            throw new NotImplementedException();
        

        public Scene? GetScene(int sceneId) =>
            Scenes.SingleOrDefault(s => s.Id == sceneId);
        
    }


    
}