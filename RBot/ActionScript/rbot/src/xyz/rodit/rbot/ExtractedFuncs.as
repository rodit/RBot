package xyz.rodit.rbot
{
	
	public class ExtractedFuncs
	{
		public function ExtractedFuncs()
		{
			super();
		}
		
		public static function actionTimeCheck(param1:*):Boolean
		{
			var _loc_2:* = 0;
			var _loc_3:* = new Date().getTime();
			var _loc_4:* = 1 - Math.min(Math.max(Main.instance.getGame().world.myAvatar.dataLeaf.sta.$tha, -1), 0.5);
			if (param1.auto)
			{
				if (Main.instance.getGame().world.autoActionTimer.running)
				{
					trace("AA TIMER SELF-CLIPPING");
					return false;
				}
				return true;
			}
			if (_loc_3 - Main.instance.getGame().world.GCDTS < Main.instance.getGame().world.GCD)
			{
				return false;
			}
			if (param1.OldCD != null)
			{
				_loc_2 = Math.round(param1.OldCD * _loc_4);
			}
			else
			{
				_loc_2 = Math.round(param1.cd * _loc_4);
			}
			if (_loc_3 - param1.ts >= _loc_2)
			{
				delete param1.OldCD;
				return true;
			}
			return false;
		}
	}
}
