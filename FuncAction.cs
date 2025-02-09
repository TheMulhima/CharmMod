using HutongGames.PlayMaker;

namespace CharmMod
{
    internal class FuncAction : FsmStateAction
    {
        private readonly Action _func;

        public FuncAction(Action func)
        {
            _func = func;
        }

        public override void OnEnter()
        {
            _func();
            Finish();
        }
    }
}