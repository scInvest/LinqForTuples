namespace CodeGeneration.Models.ParameterReplacers
{
    class ParamentersSwiperTuple_EnumerationOrT : ParamentersSwiperTuple
    {
        public ParamentersSwiperTuple_EnumerationOrT(bool thisRequired = true) : base(thisRequired)
        {
        }
        protected override ParameterTypeGenerator OverridesGenerator(string type)
        {
            var enumerable = new SameClassTupleOrEnumerableGenerator(type);
            var normal = new SameClassTupleGenerator(type);
            return new CompositeGenerator(normal, enumerable);
        }
    }
}
