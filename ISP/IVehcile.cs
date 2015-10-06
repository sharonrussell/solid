﻿namespace BreakingInterfaceSegregationPrinciple
{
    public interface IVehicle
    {
        void Accelerate();
        void Brake();
        void ChangeGear(int gear);
    }

    #region What's wrong with the above?
// At first glance it seems fine… nothing bad going on here.
// Or is there?
//
// Lets think about when we start building concrete implementations of this interface.
// An LuxuryCar class would be ok, as it can meet the contract set by the interface… 
//     However, there is going to be a lot of code in this class (potentially breaking SRP)
// And what about a MotorCycle, or a Bus, or a budget car class? 
// None of these need to implement all the methods required by the contract, so 
// we are forced to Throw Exceptions when these methods are called - and therefore write code to handle those exceptions!
    #endregion
}
