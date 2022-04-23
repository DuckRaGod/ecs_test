using Unity.Entities;
using Unity.Transforms;
using Unity.Mathematics;

public class SomeComponentSystem : ComponentSystem{

    protected override void OnUpdate(){
        // var time = Time.DeltaTime;
        // Entities.ForEach((ref Translation translation,ref SomeComponent someComponent) => {
        //     translation.Value.y += someComponent.moveSpeed * time;
        //     var posy = translation.Value.y;
        //     if(posy > 10f){
        //         someComponent.moveSpeed = -math.abs(someComponent.moveSpeed);
        //     }
        //     if(posy < -10f){
        //         someComponent.moveSpeed = +math.abs(someComponent.moveSpeed);
        //     }
        // });
    }
}   
