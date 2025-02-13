namespace CharmMod
{
    internal class PowerfulDash : Charm
    {
        public static readonly PowerfulDash Instance = new();
        public override string Sprite => "PowerfulDash.png";
        public override string Name => "Powerful Dash";
        public override string Description => "Desc";
        public override int DefaultCost => 2;
        public override string Scene => "Ruins2_11";
        public override float X => 0f;
        public override float Y => 0f;

        private PowerfulDash() { }

        public override CharmSettings Settings(SaveSettings s) => s.PowerfulDash;

        public override void Hook()
        {
            ModHooks.DashVectorHook += ChangeDashVel;
        }
        //This snippet makes you accelerate during dashes
        public Vector2 ChangeDashVel(Vector2 velocity ) {
            if(PlayerData.instance.GetBool("equippedCharm_16") && !PlayerData.instance.GetBool("equippedCharm_31") && Equipped()) {
                return velocity = velocity * 125 * Time.deltaTime;
            }
            if(PlayerData.instance.GetBool("equippedCharm_31") && !PlayerData.instance.GetBool("equippedCharm_16") && Equipped()) {
                return velocity = velocity * 100 * Time.deltaTime;
            }
            if(PlayerData.instance.GetBool("equippedCharm_16") && PlayerData.instance.GetBool("equippedCharm_31") && Equipped()) {
                return velocity = velocity * 165 * Time.deltaTime;
            }
            if(!PlayerData.instance.GetBool("equippedCharm_16") && !PlayerData.instance.GetBool("equippedCharm_31") && Equipped()) {
                return velocity = velocity * 75 * Time.deltaTime;
            }
            if(!Equipped()) {
                return velocity;
            }
            else
            {
                return velocity;
            }
        }
    }
}