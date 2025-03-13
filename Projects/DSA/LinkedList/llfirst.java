

import java.util.LinkedList;



public class llfirst {
    public static void main(String[] args) {
        LinkedList<Integer> list = new LinkedList<>();
        list.addFirst(3);
        list.addFirst(2);
        list.addFirst(8);
        list.addFirst(17);

        list.notify();
    }


}
