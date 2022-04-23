using UnityEngine;
using Unity.Entities;
using Unity.Transforms;
using Unity.Collections;
using Unity.Rendering;

public class Test : MonoBehaviour{
    [SerializeField] private Mesh mesh;
    [SerializeField] private Material material;
    void Start(){
        EntityManager entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;

        EntityArchetype entityArchetype = entityManager.CreateArchetype(
            typeof(SomeComponent),
            typeof(Translation),
            typeof(RenderMesh),
            typeof(LocalToWorld),
            typeof(RenderBounds)
        );
        NativeArray<Entity> entityArray = new NativeArray<Entity>(10000,Allocator.Temp);
        entityManager.CreateEntity(entityArchetype,entityArray);

        var lengthEntity = entityArray.Length;
        for (int i = 0; i < lengthEntity; i++){
            var entity = entityArray[i];
            // entityManager.SetComponentData(entity,new SomeComponent{moveSpeed = Random.Range(1,5)});
            entityManager.SetComponentData(entity,new Translation{Value = new Unity.Mathematics.float3(Random.Range(-10,10),Random.Range(-5,5),0)});

            entityManager.SetSharedComponentData(entity, new RenderMesh{
                mesh = mesh,
                material = material,
            });
        }

        entityArray.Dispose();
    }
}
