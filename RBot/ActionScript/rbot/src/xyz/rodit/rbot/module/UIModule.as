package xyz.rodit.rbot.module 
{
	import flash.display.MovieClip
	import xyz.rodit.rbot.Main;
	import xyz.rodit.rbot.ui.InventoryScroll;
	import xyz.rodit.rbot.ui.InventorySearch;
	import xyz.rodit.rbot.ui.UIExtension;
	public class UIModule extends Module
	{
		private var _extensions:* = new Object();
		
		public function UIModule()
		{
			super("UIModule");
			enabled = true;
			
			addExtension("mcInventory", new InventorySearch());
			addExtension("mcInventory", new InventoryScroll(["multiPanel", "splitPanel"], [4, 2]));
			addExtension("mcShop", new InventoryScroll(["multiPanel", "splitPanel", "mergePanel"], [5, 2, 8]));
		}
		
		public function addExtension(uiName:String, ext:UIExtension):void
		{
			var arr:Array = _extensions[uiName];
			if (arr == null)
			{
				_extensions[uiName] = arr = [];
			}
			arr.push(ext);
		}
		
		override public function onFrame(game:*):void 
		{
			for (var uiName:String in _extensions)
			{
				var parent:MovieClip = game.ui.mcPopup.getChildByName(uiName);
				if (parent)
				{
					for each(var ext:UIExtension in _extensions[uiName])
					{
						if (!parent.getChildByName(ext.name))
						{
							parent.addChild(ext);
							ext.onAdded(game);
						}
					}
				}
				else
				{
					for each(var ext:UIExtension in _extensions[uiName])
					{
						if (ext.parent)
						{
							ext.parent.removeChild(ext);
							ext.onRemoved(game);
						}
					}
				}
			}
		}
	}
}
