package xyz.rodit.rbot.ui 
{
	import fl.controls.TextInput;
	import flash.display.MovieClip;
	import flash.events.Event;
	import flash.text.TextField;
	import flash.text.TextFormat;
	import xyz.rodit.rbot.Main;
	public class InventorySearch extends UIExtension
	{		
		private var txtInputSearch:TextInput
		private var txtSearch:TextField;
		
		public function InventorySearch() 
		{
			name = "search";
			txtInputSearch = new TextInput();
			txtSearch = txtInputSearch.textField;
			txtSearch.embedFonts = true;
			txtSearch.defaultTextFormat = new TextFormat("Arial", 16, 0);
			txtSearch.width = 240;
			txtSearch.height = 24;
			txtSearch.textColor = 0x000000;
			txtSearch.background = true;
			txtSearch.backgroundColor = 0xFFFFFF;
			txtSearch.border = true;
			txtInputSearch.addEventListener(Event.CHANGE, textChanged);
			addChild(txtSearch);
		}
		
		override public function onAdded(game:*):void 
		{
			txtSearch.text = "";
			var backdrop:* = MovieClip(parent).multiPanel;
			x = backdrop.x + 36;
			y = backdrop.y + 14;
			stage.focus = txtSearch;
		}
		
		public function filterFunc(item:*, index:int, arr:Array):Boolean
		{
			return item.sName.toLowerCase().indexOf(txtSearch.text.toLowerCase()) > -1;
		}
		
		public function textChanged(e:Event):void
		{
			var game:* = Main.instance.getGame();
			MovieClip(parent).fOpen(
			{
				fData:
				{
					itemsInv: txtSearch.text == "" ? game.world.myAvatar.items : game.world.myAvatar.items.filter(filterFunc),
					objData: game.world.myAvatar.objData
				},
				r:
				{
					x: 0,
					y: 0,
					w: stage.stageWidth,
					h: stage.stageHeight
				},
				sMode:"inventory"
			});
			parent.setChildIndex(this, parent.numChildren - 1);
		}
	}
}
