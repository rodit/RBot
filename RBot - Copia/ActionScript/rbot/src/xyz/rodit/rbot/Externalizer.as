package xyz.rodit.rbot
{
	import flash.external.ExternalInterface;
	import xyz.rodit.rbot.remote.RemoteRegistry;
	import xyz.rodit.rbot.module.Modules;
	
	public class Externalizer
	{
		
		public function Externalizer()
		{
			super();
		}
		
		public function init(root:Main):void
		{
			this.addCallback("loadClient", Main.loadGameClient);
			this.addCallback("getGameObject", Main.getGameObject);
			this.addCallback("getGameObjectS", Main.getGameObjectS);
			this.addCallback("setGameObject", Main.setGameObject);
			this.addCallback("getArrayObject", Main.getArrayObject);
			this.addCallback("setArrayObject", Main.setArrayObject);
			this.addCallback("callGameFunction", Main.callGameFunction);
			this.addCallback("callGameFunction0", Main.callGameFunction0);
			this.addCallback("selectArrayObjects", Main.selectArrayObjects);
			this.addCallback("isNull", Main.isNull);
			
			this.addCallback("setTitle", Main.setTitle);
			this.addCallback("isLoggedIn", Main.isLoggedIn);
			this.addCallback("isKicked", Main.isKicked);
			this.addCallback("canUseSkill", Main.canUseSkill);
			this.addCallback("pickupDrops", Main.pickupDrops);
			this.addCallback("rejectExcept", Main.rejectExcept);
			this.addCallback("walkTo", Main.walkTo);
			this.addCallback("untargetSelf", Main.untargetSelf);
			this.addCallback("attackMonster", Main.attackMonster);
			this.addCallback("attackPlayer", Main.attackPlayer);
			this.addCallback("useSkill", Main.useSkill);
			this.addCallback("catchPackets", Main.catchPackets);
			this.addCallback("magnetize", Main.magnetize);
			this.addCallback("infiniteRange", Main.infiniteRange);
			this.addCallback("skipCutscenes", Main.skipCutscenes);
			this.addCallback("killLag", Main.killLag);
			this.addCallback("disableFX", Main.disableFX);
			this.addCallback("hidePlayers", Main.hidePlayers);
			this.addCallback("sendClientPacket", Main.sendClientPacket);
			this.addCallback("getDrops", Main.getDrops);
			this.addCallback("injectScript", Main.injectScript);
			this.addCallback("disableDeathAd", Main.disableDeathAd);
			this.addCallback("UserID", Main.UserID);
			this.addCallback("gender", Main.Gender);
			
			this.addCallback("lnkCreate", RemoteRegistry.ext_create);
			this.addCallback("lnkDestroy", RemoteRegistry.ext_destroy);
			this.addCallback("lnkGetChild", RemoteRegistry.ext_getChild);
			this.addCallback("lnkDeleteChild", RemoteRegistry.ext_deleteChild);
			this.addCallback("lnkGetValue", RemoteRegistry.ext_getValue);
			this.addCallback("lnkSetValue", RemoteRegistry.ext_setValue);
			this.addCallback("lnkCall", RemoteRegistry.ext_call);
			this.addCallback("lnkGetArray", RemoteRegistry.ext_getArray);
			this.addCallback("lnkSetArray", RemoteRegistry.ext_setArray);
			
			this.addCallback("fcCreate", RemoteRegistry.ext_fcCreate);
			this.addCallback("fcPush", RemoteRegistry.ext_fcPushArgs);
			this.addCallback("fcPushDirect", RemoteRegistry.ext_fcPushArgsDirect);
			this.addCallback("fcClear", RemoteRegistry.ext_fcClearArgs);
			this.addCallback("fcCallFlash", RemoteRegistry.ext_fcCallFlash);
			this.addCallback("fcCall", RemoteRegistry.ext_fcCall);
			
			this.addCallback("modEnable", Modules.enable);
			this.addCallback("modDisable", Modules.disable);
			
			this.addCallback("test", Main.test);
			
			this.debug("Externalizer::init done.");
			this.call("requestLoadGame");
		}
		
		public function addCallback(name:String, func:Function):void
		{
			ExternalInterface.addCallback(name, func);
		}
		
		public function call(name:String, ... rest):*
		{
			return ExternalInterface.call(name, rest);
		}
		
		public function debug(message:String):void
		{
			this.call("debug", message);
		}
	}
}
