//--------------------------------------
// NoCD Patch

$NoCD::enableMEsoftware = false;
$NoCD::fullScreenType = OpenGL;

function noCD1()
{
   exec("repath.cs");

   flushTextureCache();
   GuiLoadContentCtrl( simCanvas, *IDGUI_TUTORIAL);
}

function noCD2()
{
   exec("repath.cs");

   flushTextureCache();
   GuiLoadContentCtrl( simCanvas, *IDGUI_TRAINING);
}

function noCD3()
{
   exec("repath.cs");

   flushTextureCache();
   $Gui::MainMenuTab = 142003;
   GuiLoadContentCtrl( simCanvas, *IDGUI_MAIN_MENU);
}

function noCD4()
{
   exec("repath.cs");
   $ConsoleWorld::DefaultSearchPath = $ConsoleWorld::DefaultSearchPath@";;multiplayer";

   flushTextureCache();
   $Gui::MainMenuTab = 142002;
   GuiLoadContentCtrl( simCanvas, *IDGUI_MAIN_MENU);
}