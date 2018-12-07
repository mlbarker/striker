
namespace striker_poc.Handlers
{
    using Commands;
    
    
    public class InputHandler
    {
        #region Fields
        
        // NULL command
        private const ICommand NULL_COMMAND = new NullCommand();
    
        // buttons
        private ICommand m_button_x;
        private ICommand m_button_y;
        private ICommand m_button_a;
        private ICommand m_button_b;
        
        // button constants
        private const char BUTTON_X = 'x';
        private const char BUTTON_Y = 'y';
        private const char BUTTON_A = 'a';
        private const char BUTTON_B = 'b';
        
        // input container
        private char m_input;
        
        #endregion
        
        #region Public Methods
        
        public void Initialize()
        {
            m_button_x = NULL_COMMAND;
            m_button_y = NULL_COMMAND;
            m_button_a = NULL_COMMAND;
            m_button_b = NULL_COMMAND;
        }
        
        public ICommand HandleInput(char input)
        {
            m_input = input;
            
            return HandleInput();
        }
        
        public void BindButtonX(ICommand command)
        {
            Bind(m_button_x, command);
        }
        
        public void BindButtonY(ICommand* command)
        {
            Bind(m_button_y, command);
        }
        
        public void BindButtonA(ICommand* command)
        {
            Bind(m_button_a, command);
        }
        
        public void BindButtonB(ICommand* command)
        {
            Bind(m_button_b, command);
        }
        
        public void Shutdown()
        {
            if(!m_button_x.IsNull()) Shutdown(m_button_x);
            if(!m_button_y.IsNull()) Shutdown(m_button_y);
            if(!m_button_a.IsNull()) Shutdown(m_button_a);
            if(!m_button_b.IsNull()) Shutdown(m_button_b);
        }
        
        public ICommand GetNullCommand()
        {
            return NULL_COMMAND;
        }
        
        #endregion
        
        #region Private Methods
        
        private ICommand HandleInput()
        {
            if (IsPressed(BUTTON_X)) return m_button_x;
            else if (IsPressed(BUTTON_Y)) return m_button_y;
            else if (IsPressed(BUTTON_A)) return m_button_a;
            else if (IsPressed(BUTTON_B)) return m_button_b;
        }
        
        private void Bind(ICommand button, ICommand command)
        {
            button = command;
        }
        
        private bool IsPressed(char const_button)
        {
            if (const_button == m_input)
            {
                return true;
            }
            
            return false;
        }
        
        private void Shutdown(ICommand button)
        {
            button = NULL_COMMAND;
        }
        
        #endregion
    }                                                                                                                                                                                                        
}
