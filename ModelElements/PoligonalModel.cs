namespace S1.ModelElements
{
    internal class PoligonalModel
    {
        public List<Poligon>? Poligons { get; set; }
        public List<Texture>? Textures { get; set; }

        public PoligonalModel(List<Texture>? textures)
        {
            Textures = textures;
        }
    }
}