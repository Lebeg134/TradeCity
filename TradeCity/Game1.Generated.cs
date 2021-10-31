namespace JHP4SD
{
    public partial class Game1
    {
        GlueControl.GlueControlManager glueControlManager;
        partial void GeneratedInitialize () 
        {
            glueControlManager = new GlueControl.GlueControlManager(8228);
            glueControlManager.Start();
            this.Exiting += (not, used) => glueControlManager.Kill();
        }
        partial void GeneratedUpdate (Microsoft.Xna.Framework.GameTime gameTime) 
        {
        }
        partial void GeneratedDraw (Microsoft.Xna.Framework.GameTime gameTime) 
        {
        }
    }
}
