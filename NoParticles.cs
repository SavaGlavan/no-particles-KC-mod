using System.Diagnostics.Tracing;
using System.Reflection;
using Assets.Code;
using Harmony;
using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Random = UnityEngine.Random;
using static UnityEngine.ParticleSystem.Particle;
namespace KCModNoRainorSnow
{
    public class NoParticles: MonoBehaviour
    {
        void OnScriptLoad()
        {
            Weather.inst.Snow.Stop();
            Weather.inst.Rain.Stop();
            
        }


        private void Update()
        {
            Weather.inst.Snow.Stop();
            Weather.inst.Rain.Stop();
        }
    }
}