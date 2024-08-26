namespace HKX2E
{
    public enum SensingMode : sbyte
    {
        SENSE_IN_NEARBY_RIGID_BODIES = 0,
        SENSE_IN_RIGID_BODIES_OUTSIDE_THIS_CHARACTER = 1,
        SENSE_IN_OTHER_CHARACTER_RIGID_BODIES = 2,
        SENSE_IN_THIS_CHARACTER_RIGID_BODIES = 3,
        SENSE_IN_GIVEN_CHARACTER_RIGID_BODIES = 4,
        SENSE_IN_GIVEN_RIGID_BODY = 5,
        SENSE_IN_OTHER_CHARACTER_SKELETON = 6,
        SENSE_IN_THIS_CHARACTER_SKELETON = 7,
        SENSE_IN_GIVEN_CHARACTER_SKELETON = 8,
        SENSE_IN_GIVEN_LOCAL_FRAME_GROUP = 9,
    }
}

