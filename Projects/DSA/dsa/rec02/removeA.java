public class removeA {
    public static void main(String[] args) {
        remove(" ", "baccad");
    }

    public static void remove(String ans, String org ){
        if(org.isEmpty()){
            System.out.println(ans);
            return;
        }
        char ch = org.charAt(0);
        if(ch == 'a'){
            remove(ans, org.substring(1));
        }
        else{
            remove(ans + ch, org.substring(1));
        }
    }
}
