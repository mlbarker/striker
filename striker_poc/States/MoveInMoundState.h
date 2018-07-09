class MoveIntoHoleState : public BaseState
{
public:
    MoveIntoHoleState();
    virtual ~MoveIntoHoleState();
    
    virtual void Handle(BaseMole* baseMole);
};