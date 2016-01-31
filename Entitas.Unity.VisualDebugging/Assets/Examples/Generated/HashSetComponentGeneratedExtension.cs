namespace Entitas {
    public partial class Entity {
        public HashSetComponent hashSet { get { return (HashSetComponent)GetComponent(ComponentIds.HashSet); } }

        public bool hasHashSet { get { return HasComponent(ComponentIds.HashSet); } }

        public Entity AddHashSet(System.Collections.Generic.HashSet<string> newHashset) {
            var componentPool = GetComponentPool(ComponentIds.HashSet);
            var component = (HashSetComponent)(componentPool.Count > 0 ? componentPool.Pop() : new HashSetComponent());
            component.hashset = newHashset;
            return AddComponent(ComponentIds.HashSet, component);
        }

        public Entity ReplaceHashSet(System.Collections.Generic.HashSet<string> newHashset) {
            var componentPool = GetComponentPool(ComponentIds.HashSet);
            var component = (HashSetComponent)(componentPool.Count > 0 ? componentPool.Pop() : new HashSetComponent());
            component.hashset = newHashset;
            ReplaceComponent(ComponentIds.HashSet, component);
            return this;
        }

        public Entity RemoveHashSet() {
            return RemoveComponent(ComponentIds.HashSet);;
        }
    }

    public partial class Matcher {
        static IMatcher _matcherHashSet;

        public static IMatcher HashSet {
            get {
                if (_matcherHashSet == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.HashSet);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherHashSet = matcher;
                }

                return _matcherHashSet;
            }
        }
    }
}