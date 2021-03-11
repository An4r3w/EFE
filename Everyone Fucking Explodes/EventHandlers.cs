using Exiled.Events.EventArgs;
using Grenades;
using UnityEngine;
using Mirror;

namespace Everyone_Fucking_Explodes
{
    public class EventHandlers
    {
        public void OnPlayerDying(DyingEventArgs ev)
        {
            Grenade grenade =
            GameObject.Instantiate(ev.Target.ReferenceHub.GetComponent <GrenadeManager>().availableGrenades[0].grenadeInstance).GetComponent<Grenade>();
            grenade.NetworkfuseTime = Plugin.Singleton.Config.ExplodeTime;
            grenade.InitData(ev.Target.ReferenceHub.GetComponent<GrenadeManager>(), Vector3.zero, Vector3.zero);
            NetworkServer.Spawn(grenade.gameObject);

        }
    }
}
