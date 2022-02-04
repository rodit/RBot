package xyz.rodit.rbot.ui 
{
	import flash.display.MovieClip;
	import flash.events.MouseEvent;
	public class InventoryScroll extends UIExtension
	{
		public var childNames:Array = [];
		public var indices:Array = [];
		
		public function InventoryScroll(_childNames:Array, _indices:Array) 
		{
			name = "InventoryScroll";
			childNames = _childNames;
			indices = _indices;
		}
		
		override public function onAdded(game:*):void 
		{
			var k:int = 0;
			for each (var name:String in childNames)
			{
				var child:MovieClip = parent[name];
				if (child && !child.hasEventListener(MouseEvent.MOUSE_WHEEL))
				{
					child.frames[indices[k++]].mc.addEventListener(MouseEvent.MOUSE_WHEEL, InventoryScroll.onWheel, false, 0, true);
				}
			}
		}
		
		public static function onWheel(e:MouseEvent):void
		{
			//TODO: Fix merge shop scroll.
			var btn:* = e.delta > 0 ? e.currentTarget.scr.a1 : e.currentTarget.scr.a2;
			for (var i:int = 0; i < Math.abs(e.delta); i += 2)
			{
				btn.dispatchEvent(new MouseEvent(MouseEvent.CLICK));
			}
		}
	}
}
