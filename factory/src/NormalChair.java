public class NormalChair implements Chair {
    @Override
    public Boolean sitOn(){
        return true;
    }

    @Override
    public Integer pontos(){
        return 1;
    } 

    @Override
    public void getDescricao(){
       System.out.println("Cadeira Normal");
    } 
}
