import java.util.ArrayList;
import java.util.List;

public class lc448_NumDis {
    public static void main(String[] args) {
        
    }

    public static List<Integer> findDisappearedNumber(int[] nums){
        // cyclic sorting algo
        int i = 0;
        while(i < nums.length){
            int correctIndex = nums[i] - 1;
            if(nums[i] < nums.length && nums[i] != nums[correctIndex]){
                //swap
                swap(nums, i, correctIndex);
            }
            else{
                i++;
            }
        }

        List<Integer> ans = new ArrayList<>();
        for(int j=0;j<nums.length;j++){
            int indexPlusOne = j+1;
            if(nums[j] != indexPlusOne){
                ans.add(indexPlusOne) ;
            }
        }

        return ans;

    }
    public static void swap(int[] nums , int first , int second){
        int temp = nums[first];
        nums[first] = nums[second];
        nums[second] = temp;
    }
}
