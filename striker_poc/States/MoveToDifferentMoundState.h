class MoveToDifferentHoleState : public BaseState
{
public:
    MoveToDifferentHoleState();
    virtual ~MoveToDifferentHoleState();
    
    virtual void Handle(BaseMole* baseMole);
};